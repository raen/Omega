using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ContainerTypeListForm : Form
    {
        public ContainerTypeListForm()
        {
            InitializeComponent();
        }

        ContainerTypeBL _ContainerTypeBL = null;
        ContainerTypeFormTypeEnum _formType;

        public void Init()
        {
            _ContainerTypeBL = new ContainerTypeBL();
            _ContainerTypeBL.Init();
            _ContainerTypeBL.FillList();

            gridContainerType.DataSource = _ContainerTypeBL.ContainerDataSet.ContainerType;

            gridContainerType.InitColumnsAsInvisible(
                _ContainerTypeBL.ContainerDataSet.ContainerType.ContainerTypeIdColumn,
                _ContainerTypeBL.ContainerDataSet.ContainerType.ContainerKindColumn
            );
        }

        public void ShowRecordForm(ContainerTypeFormTypeEnum formType)
        {
            long containerTypeId;

            ContainerDataSet.ContainerTypeRow containerTypeRow = gridContainerType.GetFocusedDataRow() as ContainerDataSet.ContainerTypeRow;
            if (containerTypeRow == null)
                containerTypeId = -1;
            else
                containerTypeId = containerTypeRow.ContainerTypeId;

            ContainerTypeRecordForm recordForm = new ContainerTypeRecordForm();
            recordForm.Init(containerTypeId,formType);
            recordForm.ShowDialog();
        }

        private void miView_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerTypeFormTypeEnum.View);
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerTypeFormTypeEnum.Edit);
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            ShowRecordForm(ContainerTypeFormTypeEnum.New);
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            //ContainerDataSet.ContainerRow containerRow = gridContainer.GetFocusedDataRow() as ContainerDataSet.ContainerRow;
            //if (containerRow == null)
            //    return;

            //if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany zbiornik?", "Omega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    _ContainerTypeBL.DeleteContainer(containerRow.ContainerId);
            //    _ContainerTypeBL.Save();
            //    _ContainerTypeBL.FillList();
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _ContainerTypeBL.FillList();
        }

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    _ContainerTypeBL.FillList();
        //}
    }
}
