using System;
using System.Collections.Generic;
using System.Text;
using MyLib.BL;

namespace Omega
{
    class ContainerBL : LogicManager
    {

        public ContainerDataSet ContainerDataSet = null;
        public ContainerDataSet.ContainerRow MainRow = null;

        private ContainerTypeBL _ContainerTypeBL = null;
        public ContainerTypeBL ContainerTypeBL
        {
            get { return _ContainerTypeBL; }
        }


        public void Init()
        {
            ContainerDataSet = new ContainerDataSet();
            base.Init(ContainerDataSet);

            DB.InitConnection(Omega.Properties.Settings.Default.dataConnectionString/* "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projects\\c#\\Omega\\data.mdb"*/);

            InitColumnAsPrimaryKey(ContainerDataSet.Container.ContainerIdColumn);
            InitColumnAsAppCalculated(ContainerDataSet.Container.eToMeasureColumn);

            _ContainerTypeBL = new ContainerTypeBL();
            _ContainerTypeBL.Init();
            _ContainerTypeBL.FillList();
        }

        public ContainerDataSet.ContainerDataTable MainDataTable
        {
            get { return ContainerDataSet.Container; }
        }

        public ContainerDataSet.ContainerDataTable FillList()
        {
            ContainerDataSet.Container.Clear();

            DB.Fill(
               ContainerDataSet.Container,
               new Omega.MyLib.DL.SQLSelect(ContainerDataSet.Container.TableName, "WHERE " + ContainerDataSet.Container.IsDeletedColumn.ColumnName + " = 0"));

            return ContainerDataSet.Container;
        }

        public void FillRecord(long containerId)
        {
            DB.Fill(
                ContainerDataSet.Container,
                new MyLib.DL.SQLSelect(
                ContainerDataSet.Container.TableName,
                string.Format("WHERE {0} = {1}", ContainerDataSet.Container.ContainerIdColumn.ColumnName, containerId)));

            // TODO powinno byc == 1
            if (MainDataTable.Rows.Count > 0)
            {
                MainRow = MainDataTable.Rows[0] as ContainerDataSet.ContainerRow;
                MainRow.CapacityDeliveredDate = DateTime.Now;
            }
        }

        public void AddNewRecord()
        {
            MainRow = ContainerDataSet.Container.NewContainerRow();
            MainRow.ContainerName = string.Empty;
            MainRow.LiquidName = string.Empty;
            MainRow.ContainerType = (int)ContainerKindEnum.Barrel;
            MainRow.CapacityDeliveredDate = DateTime.Now;
            ContainerDataSet.Container.AddContainerRow(MainRow);
        }

        public void Save()
        {
            DB.Update(MainDataTable);
        }

        public void CalculateVa(int a, int b, int H, int d)
        {
            MainRow.CurrentHeight = H - d;
            MainRow.CurrentCapacity = _ContainerTypeBL.CalculateV(a, b, H, d);
        }

        public void CalculateVa(int d)
        {
            MainRow.CurrentHeight = _ContainerTypeBL.MainRow.Height - d;
            MainRow.CurrentCapacity = _ContainerTypeBL.CalculateV(_ContainerTypeBL.MainRow.Length, _ContainerTypeBL.MainRow.Width, _ContainerTypeBL.MainRow.Height, d);
        }

        const string FIELD_REQUIRED = "Pole nie może być puste.";

        public bool ValidateInsert()
        {
            MainRow.ClearErrors();
            bool result = true;

            if (MainRow.LiquidName == string.Empty)
            {
                result = false;
                MainRow.SetColumnError(MainDataTable.LiquidNameColumn.ColumnName, FIELD_REQUIRED);
            }

            if (MainRow.ContainerName == string.Empty)
            {
                result = false;
                MainRow.SetColumnError(MainDataTable.ContainerNameColumn.ColumnName, FIELD_REQUIRED);
            }

            if (MainRow.MinHeight <= 0 || MainRow.MinHeight >= _ContainerTypeBL.MainRow.Height)
            {
                result = false;
                MainRow.SetColumnError(MainDataTable.MinHeightColumn.ColumnName, string.Format("Liczba musi być z zakresu ({0}, {1})", 0, _ContainerTypeBL.MainRow.Height));
            }

            if (MainRow.MaxHeight <= 0 || MainRow.MaxHeight >= _ContainerTypeBL.MainRow.Height)
            {
                result = false;
                MainRow.SetColumnError(MainDataTable.MaxHeightColumn.ColumnName, string.Format("Liczba musi być z zakresu ({0}, {1})", 0, MainRow.MaxHeight));
            }

            if (MainRow.MinHeight >= MainRow.MaxHeight)
            {
                result = false;
                MainRow.SetColumnError(MainDataTable.MinHeightColumn.ColumnName, string.Format("Poziom min musi być mniejszy od poziomu max"));
                MainRow.SetColumnError(MainDataTable.MaxHeightColumn.ColumnName, string.Format("Poziom min musi być mniejszy od poziomu max"));
            }

            return result;
        }

        public void DeleteContainer(long id)
        {
            ContainerDataSet.ContainerRow containerRow = MainDataTable.FindByContainerId(id);
            containerRow.IsDeleted = true;
        }

        public List<int> GetContainerNrList()
        {
            List<int> list = new List<int>();
            foreach (ContainerDataSet.ContainerRow containerRow in ContainerDataSet.Container.Select())
            {
                list.Add(containerRow.ContainerNumber);
            }

            return list;
        }

        public void AddMeasurements()
        {
            MeasurementBL measurementBL = new MeasurementBL();
            measurementBL.Init();

            ContainerBL containerBL = new ContainerBL();
            containerBL.Init();
            containerBL.FillList();

            //dodanie aktualnego
            measurementBL.AddNewMeasurement(MainRow.ContainerId, MainRow.CurrentHeight, MainRow.CurrentCapacity);
            //przepisanie reszty
            foreach (ContainerDataSet.ContainerRow containerRow in containerBL.ContainerDataSet.Container.Select())
            {
                if (containerRow.ContainerId != MainRow.ContainerId)
                    measurementBL.AddNewMeasurement(containerRow.ContainerId, containerRow.CurrentHeight, containerRow.CurrentCapacity);
            }

            measurementBL.Save();
        }
    }
}
