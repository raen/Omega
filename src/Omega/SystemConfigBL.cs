using System;
using System.Collections.Generic;
using System.Text;
using MyLib.BL;

namespace Omega
{
    public class SystemConfigBL : LogicManager
    {
        public SystemConfigDataSet SystemConfigDataSet = null;

        public SystemConfigDataSet.SystemConfigRow MainRow = null;

        public void Init()
        {
            SystemConfigDataSet = new SystemConfigDataSet();
            base.Init(SystemConfigDataSet);

            DB.InitConnection(Omega.Properties.Settings.Default.dataConnectionString/* "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projects\\c#\\Omega\\data.mdb"*/);

            InitColumnAsPrimaryKey(SystemConfigDataSet.SystemConfig.SystemConfigIdColumn);
        }

        public SystemConfigDataSet.SystemConfigDataTable MainDataTable
        {
            get { return SystemConfigDataSet.SystemConfig; }
        }

        public void FillRecord()
        {
            DB.Fill(SystemConfigDataSet.SystemConfig);

            if (MainDataTable.Rows.Count == 0)
                AddNewRecord();

            MainRow = MainDataTable.Rows[0] as SystemConfigDataSet.SystemConfigRow;
        }

        public void AddNewRecord()
        {
            MainRow = SystemConfigDataSet.SystemConfig.NewSystemConfigRow();
            MainRow.ComName = "COM1";
            SystemConfigDataSet.SystemConfig.AddSystemConfigRow(MainRow);
        }

        public void Save()
        {
            DB.Update(MainDataTable);
        }
    }
}
