using System;
using System.Collections.Generic;
using System.Text;
using MyLib.BL;

namespace Omega
{
    public class ContainerTypeBL : LogicManager
    {
        #region consts

        public static int DEFAULT_HEIGHT = 844;
        public static int DEFAULT_CAPACITY = 211;
        public static int DEFAULT_LENGHT = 282;

        #endregion 

        public ContainerDataSet ContainerDataSet = null;

        public ContainerDataSet.ContainerTypeRow MainRow = null;

        public void Init()
        {
            ContainerDataSet = new ContainerDataSet();
            base.Init(ContainerDataSet);

            DB.InitConnection(Omega.Properties.Settings.Default.dataConnectionString/* "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projects\\c#\\Omega\\data.mdb"*/);

            InitColumnAsPrimaryKey(ContainerDataSet.ContainerType.ContainerTypeIdColumn);
        }

        public ContainerDataSet.ContainerTypeDataTable MainDataTable
        {
            get { return ContainerDataSet.ContainerType; }
        }

        public ContainerDataSet.ContainerTypeDataTable FillList()
        {
            ContainerDataSet.ContainerType.Clear();

            DB.Fill(ContainerDataSet.ContainerType);

            return ContainerDataSet.ContainerType;
        }

        public void FillRecord(long containerTypeId)
        {
            DB.Fill(
                ContainerDataSet.ContainerType,
                new MyLib.DL.SQLSelect(
                ContainerDataSet.ContainerType.TableName,
                string.Format("WHERE {0} = {1}", ContainerDataSet.ContainerType.ContainerTypeIdColumn.ColumnName, containerTypeId)));

            MainRow = MainDataTable.Rows[0] as ContainerDataSet.ContainerTypeRow;
        }

        public void AddNewRecord()
        {
            MainRow = ContainerDataSet.ContainerType.NewContainerTypeRow();
            MainRow.Height = DEFAULT_HEIGHT;
            MainRow.ContainerKind = (int)ContainerKindEnum.Barrel;
            MainRow.Length = DEFAULT_LENGHT;
            MainRow.Capacity = DEFAULT_CAPACITY;
            MainRow.ContainerTypeName = string.Empty;
            MainRow.Width = 0;
            ContainerDataSet.ContainerType.AddContainerTypeRow(MainRow);
        }

        public void Save()
        {
            DB.Update(MainDataTable);
        }

        public int CalculateV(int a, int b, int H, int d)
        {
            int capacity = 0;
            //int cos =  (int)MainRow[MainDataTable.HeightColumn, System.Data.DataRowVersion.Original];
            switch ((ContainerKindEnum)MainRow.ContainerKind)
            {
                case ContainerKindEnum.Barrel:
                    capacity = (int)((H - d) * 0.25);
                    break;
                case ContainerKindEnum.Cuboid:
                    capacity = (int)a * b * (H - d) / 1000000;
                    break;
                case ContainerKindEnum.CylinderL:
                    capacity = (int)(Math.Abs(H * (d - a) * (-Math.Pow(d, 2) + 2 * a * d) - H * Math.Pow(a, 2) * Math.Asin((-d + a) / a) + 0.5 * H * Math.PI * Math.Pow(a, 2)) / 1000000);
                    break;
                case ContainerKindEnum.CylinderS:
                    capacity = (int)((Math.PI * Math.Pow(a, 2) * (H - d)) / 1000000);
                    break;
                case ContainerKindEnum.Other:
                    capacity = (int)(MainRow.Capacity - (decimal)((decimal)MainRow.Capacity / (decimal)MainRow.Height) * (decimal)d);
                    break;
                default:
                    capacity = 0;
                    break;
            }

            return capacity;
        }

        public void CalculateVc(int a, int b, int H, int d)
        {
            MainRow.Capacity = CalculateV(a, b, H, d);
        }
    }
}
