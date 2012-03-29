using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ContainerChooseForm : Form
    {
        public ContainerChooseForm()
        {
            InitializeComponent();
        }

        private ContainerBL _containerBL;
        public void Init()
        {
            _containerBL = new ContainerBL();
            _containerBL.Init();
            //_containerDataTable =
            gridContainer.DataSource = _containerBL.FillList();

            foreach (DataColumn dataColumn in _containerBL.ContainerDataSet.Container.Columns)
            {
                if (dataColumn == _containerBL.ContainerDataSet.Container.ContainerNameColumn || dataColumn == _containerBL.ContainerDataSet.Container.ContainerNumberColumn || dataColumn == _containerBL.ContainerDataSet.Container.eToMeasureColumn)
                    continue;

                gridContainer.InitColumnsAsInvisible(dataColumn);
            }
        }

        public List<long> CheckedContainers
        {
            get
            {
                List<long> list = new List<long>();
                ContainerDataSet.ContainerRow[] arrContainer = (ContainerDataSet.ContainerRow[])_containerBL.ContainerDataSet.Container.Select(_containerBL.ContainerDataSet.Container.eToMeasureColumn.ColumnName + " = 1");
                foreach (ContainerDataSet.ContainerRow row in arrContainer)
                    list.Add(row.ContainerId);

                return list;
            }
        }
    }
}