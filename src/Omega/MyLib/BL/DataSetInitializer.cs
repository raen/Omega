using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyLib.BL
{
    public class DatasetInitializer
    {
        public void InitColumnAsJoined(DataColumn joinedColumn, string joinedFromTableName)
        {
            joinedColumn.ExtendedProperties[DataColumnExtProperties.IsJoined] = true;
            joinedColumn.ExtendedProperties[DataColumnExtProperties.JoinedTableName] = joinedFromTableName;
        }

        public void InitColumnAsPrimaryKey(DataColumn primaryKeyColumn)
        {
            primaryKeyColumn.ExtendedProperties[DataColumnExtProperties.IsPrimaryKey] = true;
            primaryKeyColumn.ExtendedProperties[DataColumnExtProperties.PrimaryKeyColumnName] = primaryKeyColumn.ColumnName;
        }

        public void InitColumnAsNotUsed(DataColumn notUsedColumn)
        {
            notUsedColumn.ExtendedProperties[DataColumnExtProperties.ColumnNotUsed] = true;
        }

        public void InitColumnAsAppCalculated(DataColumn dataColumn)
        {
            dataColumn.ExtendedProperties[DataColumnExtProperties.AppCalculated] = true;
        }
    }
}
