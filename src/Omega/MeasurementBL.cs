using System;
using System.Collections.Generic;
using System.Text;
using MyLib.BL;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Omega
{
    class MeasurementBL : LogicManager
    {

        public MeasurementDataSet MeasurementDataSet;

        
        public void Init()
        {
            MeasurementDataSet = new MeasurementDataSet();

            base.Init(MeasurementDataSet);

            DB.InitConnection(Omega.Properties.Settings.Default.dataConnectionString/*"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projects\\c#\\Omega\\data.mdb"*/);

            InitColumnAsPrimaryKey(MeasurementDataSet.Measurement.MeasurementIdColumn);
        }

        // TODO sprawdzic cos windows 7 sypie sie na parametrach
        public void Fill(DateTime from, DateTime to)
        {
            MeasurementDataSet.Clear();

            DB.Fill(MeasurementDataSet.vMeasurement);
            //string paramFromName = "@DateFrom",
            //    paramToName = "@DateTo";
            //OleDbParameter paramFrom = new OleDbParameter(paramFromName, from),
            //    paramTo = new OleDbParameter(paramToName, to);

            //DB.Fill(MeasurementDataSet.vMeasurement, 
            //    new Omega.MyLib.DL.SQLSelect(
            //    MeasurementDataSet.vMeasurement.TableName,
            //    "WHERE " + MeasurementDataSet.vMeasurement.MeasurementDateColumn.ColumnName + " >= " + paramFromName +  " AND " + 
            //    MeasurementDataSet.vMeasurement.MeasurementDateColumn.ColumnName + " <= " + paramToName + ""), paramFrom, paramTo);
        }

        public void AddNewMeasurement(long pContainer, int height, int capacity)
        {
            MeasurementDataSet.Measurement.AddMeasurementRow(DateTime.Now, pContainer, capacity, height); 
        }

        public void Save()
        {
            DB.Update(MeasurementDataSet.Measurement);
        }
    }
}
