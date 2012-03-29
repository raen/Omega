using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ContainerTypeRecordForm : Form
    {
        public ContainerTypeRecordForm()
        {
            InitializeComponent();
        }

        ContainerTypeBL _ContainerTypeBL = null;

        private bool isInitializing = true;

        public void Init(long containerTypeId, ContainerTypeFormTypeEnum formType)
        {
            isInitializing = true;

            //Wczytywanie dancyh 
            _ContainerTypeBL = new ContainerTypeBL();
            _ContainerTypeBL.Init();
            if (formType == ContainerTypeFormTypeEnum.New)
                _ContainerTypeBL.AddNewRecord();
            else
                _ContainerTypeBL.FillRecord(containerTypeId);

            ContainerKindEnum list = ContainerKindEnum.Barrel;
            comboContainerKind.Init(list, typeof(ContainerKindEnum));

            BindControls();

            switch (formType)
            {
                case ContainerTypeFormTypeEnum.Edit:

                    break;
                case ContainerTypeFormTypeEnum.New:

                    break;
                case ContainerTypeFormTypeEnum.View:
                    tbContainerTypeName.ReadOnly = true;
                    tbCapacity.ReadOnly = true;
                    tbHeight.ReadOnly = true;
                    tbWidth.ReadOnly = true;
                    tbLength.ReadOnly = true;
                    comboContainerKind.Enabled = false;
                    break;
            }
        }

        private void BindControls()
        {
            bindingSource1.DataSource = _ContainerTypeBL.MainRow;

            BindControl(tbContainerTypeName, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.ContainerTypeNameColumn);
            BindControl(tbCapacity, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.CapacityColumn);
            BindControl(tbHeight, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.HeightColumn);
            BindControl(tbWidth, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.WidthColumn);
            BindControl(tbLength, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.LengthColumn);
            BindControl(comboContainerKind, _ContainerTypeBL.ContainerDataSet.ContainerType, _ContainerTypeBL.ContainerDataSet.ContainerType.ContainerKindColumn);
        }

        private void BindControl(Control control, DataTable dataTable, DataColumn dataColumn)
        {
            string propertyName = string.Empty;

            if (control is TextBox)
                propertyName = "Text";
            else if (control is NumericUpDown)
                propertyName = "Value";
            else if (control is ComboBox)
                propertyName = "SelectedValue";

            control.DataBindings.Add(propertyName, bindingSource1, dataColumn.ColumnName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _ContainerTypeBL.Save();
                
                MessageBox.Show("Dane zostały zapisane.", "Omega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystąpiły błędy podczas zapiywania danych. {0}", ex.Message), "Omega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _ContainerTypeBL.CalculateVc((int)tbLength.Value, (int)tbWidth.Value, (int)tbHeight.Value, 0);
            tbCapacity.Value = _ContainerTypeBL.MainRow.Capacity;
        }

        private void comboContainerKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ContainerKindEnum)comboContainerKind.SelectedValue)
            {
                //dla beczki domyślne wartości - nie do edycji
                case ContainerKindEnum.Barrel:
                    tbCapacity.ReadOnly = true;
                    tbHeight.ReadOnly = true;
                    tbWidth.ReadOnly = true;
                    tbLength.ReadOnly = true;
                    _ContainerTypeBL.MainRow.Height = ContainerTypeBL.DEFAULT_HEIGHT;
                    _ContainerTypeBL.MainRow.Length = ContainerTypeBL.DEFAULT_LENGHT;
                    _ContainerTypeBL.MainRow.Capacity = ContainerTypeBL.DEFAULT_CAPACITY;
                    _ContainerTypeBL.MainRow.Width = 0;
                    break;
                default:
                    tbCapacity.ReadOnly = false;
                    tbHeight.ReadOnly = false;
                    tbWidth.ReadOnly = false;
                    tbLength.ReadOnly = false;

                    break;
            }
        }
    }
}
