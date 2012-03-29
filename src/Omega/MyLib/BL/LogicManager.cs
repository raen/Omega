using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyLib.BL
{
    public class LogicManager : DatasetInitializer
    {
        public MyLib.DL.OleDBDataManager DB;

        public void Init(DataSet ds)
        {
            DB = new MyLib.DL.OleDBDataManager();

            // dodawanie niezbednych dodatkowych opcji do kolumn
            foreach(DataTable dt in ds.Tables)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    dc.ExtendedProperties.Add(DataColumnExtProperties.IsJoined,false);
                    dc.ExtendedProperties.Add(DataColumnExtProperties.JoinedTableName,"");
                    dc.ExtendedProperties.Add(DataColumnExtProperties.IsPrimaryKey, false);
                    dc.ExtendedProperties.Add(DataColumnExtProperties.ColumnNotUsed, false);
                    dc.ExtendedProperties.Add(DataColumnExtProperties.AppCalculated, false);
                }
            }
        }

        /// <summary>
        /// inicjalizuje kolumny jako zjoinowane z innej tabeli
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dataColumns"></param>
        protected void InitColumnsAsJoined(string tableName, params DataColumn[] dataColumns)
        {
            foreach (DataColumn dc in dataColumns)
            {
                InitColumnAsJoined(dc, tableName);
            }
        }

        protected void InitColumnsAsPrimaryKey(params DataColumn[] dataColumns)
        {
            foreach (DataColumn dc in dataColumns)
            {
                InitColumnAsPrimaryKey(dc);
            }
        }

        protected void InitColumnsAsNotUsed(params DataColumn[] dataColumns)
        {
            foreach (DataColumn dc in dataColumns)
            {
                InitColumnAsNotUsed(dc);
            }
        }
    }
}
