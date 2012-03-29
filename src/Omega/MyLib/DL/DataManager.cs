using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

using Omega.MyLib.DL;


namespace MyLib.DL
{
    // narazei bedzie sie nadawal do polaczen typu OLE - stad nazwa, UOGOLNIC!!!
    public class OleDBDataManager 
    {

        private OleDbConnection ConnectionDB = null;

        bool isInitialized = false;

        public void InitConnection(string connectionString)
        {
            ConnectionDB = new OleDbConnection(connectionString);
        }

        #region funkcje zwracajace rozszerzone property DataColumn

        private bool IsDataColumnJoined(DataColumn dc)
        {
            return (bool)dc.ExtendedProperties[DataColumnExtProperties.IsJoined];
        }

        private string GetDataColumnJoinedTableName(DataColumn dc)
        {
            return (string)dc.ExtendedProperties[DataColumnExtProperties.JoinedTableName];
        }

        private bool IsDataColumnPrimaryKey(DataColumn dc)
        {
            return (bool)dc.ExtendedProperties[DataColumnExtProperties.IsPrimaryKey];
        }

        private string GetDataColumnPrimaryKeyValue(DataColumn dc)
        {
            return (string)dc.ExtendedProperties[DataColumnExtProperties.PrimaryKeyColumnName].ToString();
        }

        private bool IsDataColumNotUsed(DataColumn dc)
        {
            return (bool)dc.ExtendedProperties[DataColumnExtProperties.ColumnNotUsed];
        }

        private bool IsDataColumAppCalculated(DataColumn dc)
        {
            return (bool)dc.ExtendedProperties[DataColumnExtProperties.AppCalculated];
        }

        #endregion

        /*
        protected virtual DataSet MainDataSet
        {
            set { throw new Exception("not implementeD"); }
        }
        */
        
        /// <summary>
        /// obsluga zapisow - narazie tylko INSERTY
        /// </summary>
        /// <param name="dtSaving"></param>
        /// <param name="DBConnection"></param>
        public void Update(DataTable dataTable /* tymczasowo - domyslnie ten obiekt bedzie zmienna tej klasy*/)
        {
            //TODO kazda operacja updateu zbiorczo (zebrac sqlcommand zbiorczy osobno dla INSERT, DELETE, UPDATE)
            // petla dla kazdego typu operacji oddzielnie
            // ?? wywolac w odpowiedniej kolejnosci gotowe commandy (wydaje mi sie ze po kolei: INSERT, UPDATE, DELETE

            // 1. BuildRemoveCommand
            string removeCommand = BuildRemoveCommand(dataTable);
            // 2. BuildInserCommand
            List<string> insertCommands = BuildInsertCommands(dataTable);
            // 3. BuildUpdateCommand
            List<string> updateCommands = BuildUpdateCommands(dataTable);

            // odwolania do bazy w tej samej kolejnosci + sprawdzanie czy cos poszlo nie tak

            
            // 1. InserExecute
            if (insertCommands.Count > 0)
                ExecuteInsertCommand(dataTable, insertCommands);
            // 2. UpdateExecute
            if (updateCommands.Count > 0)
                ExecuteUpdateCommand(dataTable, updateCommands);
            // 3. RemoveExecute
            if(removeCommand != string.Empty)
                ExecuteRemoveCommand(dataTable, removeCommand);

            /*
            foreach (DataRow drSaving in dtSaving.Select("","", DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent))
            {   
                if (drSaving.RowState == DataRowState.Added)
                {
                    DBInsert(drSaving);
                }
                else if (drSaving.RowState == DataRowState.Modified)
                {
                    DBUpdate(drSaving);
                }
                else if (drSaving.RowState == DataRowState.Deleted)
                {
                    DBRemove(drSaving);
                }
            }*/
            //dataTable.AcceptChanges();
        }

        private string BuildRemoveCommand(DataTable dataTable)
        {
            DataRow[] arrDataRow = dataTable.Select("", "", DataViewRowState.Deleted);
            if(arrDataRow.Length <= 0)
                return string.Empty;

            // Sprawdzam czy zdefiniowano klucz glowny
            DataColumn dcPrimaryKey = null;
            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                    if (IsDataColumnPrimaryKey(dataColumn))
                        dcPrimaryKey = dataColumn;
            }
            if (dcPrimaryKey == null)
                throw new Exception("nie zdefiniowano klucza glownego");
            

            // budowanie zapytania
            string command = "DELETE FROM [" + dataTable.TableName + "] WHERE " + dcPrimaryKey.ColumnName + " IN (";
            foreach (DataRow dataRow in dataTable.Select("", "", DataViewRowState.Deleted))
            {
                //TODO - jako parametr klucza glownego wchodzi long - ma innny format od np string czy DataTime - trzeba jakos to kontrolowac!!!
                command += dataRow[dcPrimaryKey, DataRowVersion.Original].ToString() + ", ";
            }
            command = command.TrimEnd(',', ' ');
            command += ")";

            return command;
        }

        private List<string> BuildUpdateCommands(DataTable dataTable)
        {
            List<string> commands = new List<string>();
            DataRow[] arrDataRow = dataTable.Select("", "", DataViewRowState.ModifiedOriginal | DataViewRowState.ModifiedCurrent);
            if (arrDataRow.Length <= 0)
                return commands;

            foreach (DataRow dataRow in arrDataRow)
            {
                string command = "UPDATE [" + dataTable.TableName + "] SET ";
                DataColumn dcPrimaryKey = null;
                foreach (DataColumn dcUpdating in dataTable.Columns)
                {
                    if (!IsDataColumnPrimaryKey(dcUpdating) && !(IsDataColumnJoined(dcUpdating)) && (!IsDataColumNotUsed(dcUpdating)) && !IsDataColumAppCalculated(dcUpdating))
                    {
                        command += "[" + dcUpdating.ColumnName + "] = " + ConvertToCorrectFormat(dataRow, dcUpdating) + ", ";
                    }
                    if (IsDataColumnPrimaryKey(dcUpdating))
                        dcPrimaryKey = dcUpdating;
                }
                command = command.TrimEnd(',', ' ');
                if (dcPrimaryKey == null)
                {
                    commands.Clear();
                    throw new Exception("nie zdefiniowano klucza glownego");
                }

                //TODO - jako parametr klucza glownego wchodzi long - ma innny format od np string czy DataTime - trzeba jakos to kontrolowac!!!
                command += " WHERE (" + dcPrimaryKey.ColumnName + " = " + dataRow[dcPrimaryKey].ToString() + ")";
                commands.Add(command);
            }
            return commands;
        }

        private List<string> BuildInsertCommands(DataTable dataTable)
        {
            List<string> commands = new List<string>();
            DataRow[] arrDataRow = dataTable.Select("", "", DataViewRowState.Added);
            if (arrDataRow.Length <= 0)
                return commands;

            foreach (DataRow dataRow in arrDataRow)
            {
                string command = "INSERT INTO [" + dataTable.TableName + "] (";
                foreach (DataColumn dcSaving in dataTable.Columns)
                {
                    if (!IsDataColumnPrimaryKey(dcSaving) && !(IsDataColumnJoined(dcSaving)) && !IsDataColumNotUsed(dcSaving) && !IsDataColumAppCalculated(dcSaving))
                    {
                        command += "[" + dcSaving.ColumnName + "], ";
                    }
                }
                command = command.TrimEnd(',', ' ');
                command += ") VALUES (";

                foreach (DataColumn dcSaving in dataTable.Columns)
                {
                    if (!IsDataColumnPrimaryKey(dcSaving) && !(IsDataColumnJoined(dcSaving)) && !IsDataColumNotUsed(dcSaving) && !IsDataColumAppCalculated(dcSaving))
                    {
                        //TODO ogarnac wszystkie formaty
                        command += ConvertToCorrectFormat(dataRow, dcSaving) + ", ";
                    }
                }
                command = command.TrimEnd(',', ' ');
                command += ")";

                commands.Add(command);
            }
            return commands;
        }

        private void ExecuteRemoveCommand(DataTable dataTable, string removeCommand)
        {
            OleDbCommand OleDBCommand = new OleDbCommand(removeCommand);
            OleDBCommand.CommandText = removeCommand;
            OleDBCommand.Connection = ConnectionDB;

            try
            {
                ConnectionDB.Open();
                OleDBCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Nieudane usuwanie z bazy");
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        private void ExecuteUpdateCommand(DataTable dataTable, List<string> updateCommands)
        {
            OleDbCommand oleDBCommand = new OleDbCommand();
            oleDBCommand.Connection = ConnectionDB;

            try
            {
                ConnectionDB.Open();
                foreach (string updateCommand in updateCommands)
                {
                    oleDBCommand.CommandText = updateCommand;
                    oleDBCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Nieudane usuwanie z bazy");
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        private void ExecuteInsertCommand(DataTable dataTable, List<string> insertCommands)
        {
            OleDbCommand oleDBCommand = new OleDbCommand();
            oleDBCommand.Connection = ConnectionDB;

            try
            {
                ConnectionDB.Open();
                foreach (string insertCommand in insertCommands)
                {
                    oleDBCommand.CommandText = insertCommand;
                    oleDBCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Nieudane dodawanie do bazy");
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        private void DBInsert(DataRow drSaving)
        {
            OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlCommand = ConnectionDB.CreateCommand();

            string command = "INSERT INTO " + drSaving.Table.TableName + " (";
            foreach (DataColumn dcSaving in drSaving.Table.Columns)
            {
                if (!IsDataColumnPrimaryKey(dcSaving) && !(IsDataColumnJoined(dcSaving)) && !IsDataColumNotUsed(dcSaving))
                {
                    command += "[" + dcSaving.ColumnName + "], ";
                }
            }
            command = command.TrimEnd(',', ' ');
            command += ") VALUES (";

            foreach (DataColumn dcSaving in drSaving.Table.Columns)
            {
                if (!IsDataColumnPrimaryKey(dcSaving) && !IsDataColumnJoined(dcSaving) && !IsDataColumNotUsed(dcSaving) && !IsDataColumAppCalculated(dcSaving))
                {
                    //TODO ogarnac wszystkie formaty
                    command += ConvertToCorrectFormat(drSaving,dcSaving) + ", ";
                }
            }
            command = command.TrimEnd(',', ' ');
            command += ")";
            sqlCommand.CommandText = command;
            sqlAdapter.InsertCommand = sqlCommand;
            sqlAdapter.Update(drSaving.Table);
        }

        private string ConvertBoolToCorrectFormat(DataRow dataRow, DataColumn dataColumn)
        {
            bool value = (bool) dataRow[dataColumn];
            if (value == true)
                return "'1'";
            else
                return "'0'"; 
        }

        private string ConvertToCorrectFormat(DataRow dataRow, DataColumn dataColumn)
        {
            if (dataRow[dataColumn].GetType() == typeof(Boolean))
                return ConvertBoolToCorrectFormat(dataRow, dataColumn);
            else if (dataRow.IsNull(dataColumn))
                return "NULL";
            else
                return "'" + dataRow[dataColumn].ToString() + "'";
        }

        /// <summary>
        /// Update do bazy - narazie dziala tylko dla pojedynczego klucza glownego
        /// </summary>
        /// <param name="drUpdating"></param>
        private void DBUpdate(DataRow drUpdating)
        {
            OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlCommand = ConnectionDB.CreateCommand();

            DataColumn dcPrimaryKey = null; // tu powinna byc kolekcja (do obslugi wielokrotnego klucza)

            string command = "UPDATE " + drUpdating.Table.TableName + " SET ";
            foreach (DataColumn dcUpdating in drUpdating.Table.Columns)
            {
                if (!IsDataColumnPrimaryKey(dcUpdating) && !(IsDataColumnJoined(dcUpdating)) && (!IsDataColumNotUsed(dcUpdating)) && !IsDataColumAppCalculated(dcUpdating))
                {
                    command += "[" + dcUpdating.ColumnName + "] = " + ConvertToCorrectFormat(drUpdating, dcUpdating) + ", ";
                }
                if(IsDataColumnPrimaryKey(dcUpdating))
                    dcPrimaryKey = dcUpdating;
            }
            command = command.TrimEnd(',', ' ');
            if(dcPrimaryKey == null)
                throw new Exception("nie zdefiniowano klucza glownego");

            //TODO - jako parametr klucza glownego wchodzi long - ma innny format od np string czy DataTime - trzeba jakos to kontrolowac!!!
            command += " WHERE (" + dcPrimaryKey.ColumnName + " = " + drUpdating[dcPrimaryKey].ToString() + ")";

            sqlCommand.CommandText = command;
            sqlAdapter.UpdateCommand = sqlCommand;
            sqlAdapter.Update(drUpdating.Table);
        }

        //PROTOTYPE - nie sprawdza sie dla przypadku wielu wierszy na raz
        //2DELETE - zastapione przez BuildRemoveCommand() i ExecuteRemoveCommand()
        private void DBRemove(DataRow drRemoving)
        {
            OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlCommand = ConnectionDB.CreateCommand();

            DataColumn dcPrimaryKey = null; // tu powinna byc kolekcja (do obslugi wielokrotnego klucza)

            string command = "DELETE FROM " + drRemoving.Table.TableName;
            foreach (DataColumn dcRemoving in drRemoving.Table.Columns)
            {
                if (IsDataColumnPrimaryKey(dcRemoving))
                    dcPrimaryKey = dcRemoving;
            }
            if (dcPrimaryKey == null)
                throw new Exception("nie zdefiniowano klucza glownego");

            //TODO - jako parametr klucza glownego wchodzi long - ma innny format od np string czy DataTime - trzeba jakos to kontrolowac!!!
            command += " WHERE (" + dcPrimaryKey.ColumnName + " = " + drRemoving[dcPrimaryKey, DataRowVersion.Original].ToString() + ")";

            sqlCommand.CommandText = command;
            sqlAdapter.DeleteCommand = sqlCommand;
            sqlAdapter.Update(drRemoving.Table);
        }
        
        //2DEL
        public void Fill(DataTable dataTable, string selectCommand)
        {
            OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
            OleDbCommand sqlCommand = ConnectionDB.CreateCommand();
            sqlCommand.CommandText = selectCommand;
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);
        }

        public void Fill(DataTable dataTable, SQLSelect selectCommand, params OleDbParameter[] parameters)
        {
            OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();

            OleDbCommand sqlCommand = ConnectionDB.CreateCommand();

            string command = "SELECT ";
            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                if (IsDataColumAppCalculated(dataColumn))
                    continue;

                if (IsDataColumnJoined(dataColumn))
                    command += "[" + GetDataColumnJoinedTableName(dataColumn) + "].[" + dataColumn.ColumnName + "], ";
                else
                    command += "[" + dataColumn.Table.TableName + "].[" + dataColumn.ColumnName + "], ";
            }

            command = command.TrimEnd(',', ' ');
            command += " FROM [";
            command += selectCommand.From + "]";

            // dodawanie whera (jesli istnieje)
            if (command != string.Empty)
                command += " " + selectCommand.Where;

            sqlCommand.CommandText = command;
            sqlAdapter.SelectCommand = sqlCommand;

            //Dodanie parametrów
            foreach (OleDbParameter parameter in parameters)
                sqlAdapter.SelectCommand.Parameters.Add(parameter);

            sqlAdapter.Fill(dataTable);
        }

        public DataTable Fill(DataTable dataTable, SQLSelect selectCommand)
        {
            Fill(dataTable, selectCommand, new OleDbParameter[] { });
            //OleDbDataAdapter sqlAdapter = new OleDbDataAdapter();
            //OleDbCommand sqlCommand = ConnectionDB.CreateCommand();

            //string command = "SELECT ";
            //foreach (DataColumn dataColumn in dataTable.Columns)
            //{
            //    if (IsDataColumAppCalculated(dataColumn))
            //        continue;

            //    if (IsDataColumnJoined(dataColumn))
            //        command += "[" + GetDataColumnJoinedTableName(dataColumn) + "].[" + dataColumn.ColumnName + "], ";
            //    else
            //        command += "[" + dataColumn.Table.TableName + "].[" + dataColumn.ColumnName + "], ";
            //}

            //command = command.TrimEnd(',', ' ');
            //command += " FROM [";
            //command += selectCommand.From + "]";

            //// dodawanie whera (jesli istnieje)
            //if (command != string.Empty)
            //    command += " " + selectCommand.Where;

            //sqlCommand.CommandText = command;
            //sqlAdapter.SelectCommand = sqlCommand;
            //sqlAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable Fill(DataTable dataTable)
        {
            Fill(dataTable, new SQLSelect(dataTable.TableName));

            return dataTable;
        }

        /// <summary>
        /// Wykonuje zapytanie o jedna kolumne (SELECT column FROM table WHERE ...)
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, string paramName, string paramValue)
        {
            OleDbCommand oleDBCommand = new OleDbCommand();
            oleDBCommand.Connection = ConnectionDB;

            try
            {
                ConnectionDB.Open();
                oleDBCommand.CommandText = sql;

                oleDBCommand.Parameters.Add(paramName, OleDbType.VarChar);
                oleDBCommand.Parameters[paramName].Value = paramValue;

                return oleDBCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception("Nieudane ExecuteScalar");
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            OleDbCommand oleDBCommand = new OleDbCommand();
            oleDBCommand.Connection = ConnectionDB;

            try
            {
                ConnectionDB.Open();
                oleDBCommand.CommandText = sql;

                return oleDBCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Nieudane ExecuteNonQuery: {0}", e.Message));
            }
            finally
            {
                ConnectionDB.Close();
            }
        }
    }
}
