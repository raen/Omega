 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ContainerListForm : Form
    {
        public ContainerListForm()
        {
            InitializeComponent();
        }


        ContainerBL _ContainerBL = null;

        public void Init()
        {
            _ContainerBL = new ContainerBL();
            _ContainerBL.Init();
            _ContainerBL.FillList();

            gridContainer.DataSource = _ContainerBL.ContainerDataSet.Container;

            gridContainer.InitColumnsAsInvisible(
                _ContainerBL.ContainerDataSet.Container.eToMeasureColumn,
                _ContainerBL.ContainerDataSet.Container.IsCapacityGrowColumn,
                _ContainerBL.ContainerDataSet.Container.ContainerIdColumn,
                _ContainerBL.ContainerDataSet.Container.CapacityDeliveredColumn,
                _ContainerBL.ContainerDataSet.Container.CapacityDeliveredDateColumn,
                _ContainerBL.ContainerDataSet.Container.IsDeletedColumn,
                _ContainerBL.ContainerDataSet.Container.ContainerTypeColumn,
                _ContainerBL.ContainerDataSet.Container.MaxHeightColumn,
                _ContainerBL.ContainerDataSet.Container.MinHeightColumn
            );
        }


        public void ShowRecordForm(ContainerFormTypeEnum formType)
        {
            long containerId;

            ContainerDataSet.ContainerRow containerRow = gridContainer.GetFocusedDataRow() as ContainerDataSet.ContainerRow;
            if (containerRow == null)
                containerId = -1;
            else
                containerId = containerRow.ContainerId;

            ContainerRecordForm recordForm = new ContainerRecordForm();
            if(recordForm.Init(containerId, formType,_ContainerBL.GetContainerNrList()))
                recordForm.ShowDialog();
        }

        private void miView_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerFormTypeEnum.View);
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerFormTypeEnum.Edit);
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerFormTypeEnum.New);
        }

        private void miUpdate_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerFormTypeEnum.Update);
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            ContainerDataSet.ContainerRow containerRow = gridContainer.GetFocusedDataRow() as ContainerDataSet.ContainerRow;
            if (containerRow == null)
                return;

            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany zbiornik?", "Omega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ContainerBL.DeleteContainer(containerRow.ContainerId);
                _ContainerBL.Save();
                _ContainerBL.FillList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _ContainerBL.FillList();
        }
    }
}