using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ContainerRecordForm : Form
    {
        #region init

        public ContainerRecordForm()
        {
            InitializeComponent();
        }

        ContainerBL _ContainerBL = null;
        ContainerFormTypeEnum _formType;
        List<int> _containerNumberList = new List<int>();
        private bool isInitializing = true;

        public bool Init(long containerId, ContainerFormTypeEnum formType, List<int> containerNumberList)
        {
            isInitializing = true;

            _containerNumberList = containerNumberList;
            _formType = formType;
            //Wczytywanie dancyh 
            _ContainerBL = new ContainerBL();
            _ContainerBL.Init();
            if (formType == ContainerFormTypeEnum.New)
                _ContainerBL.AddNewRecord();
            else
                _ContainerBL.FillRecord(containerId);

            if (_ContainerBL.ContainerTypeBL.ContainerDataSet.ContainerType.Rows.Count == 0)
            {
                MessageBox.Show("Nie zdefioniowano żadnych pojemników.", "Operacje na zbiornikach nie są możliwe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BindControls();

            if (_formType == ContainerFormTypeEnum.Update)
            {
                //tbCurrentDistance.Maximum = _ContainerBL.MainRow.Capacity;
                //tbCurrencyHeigh.Maximum = _ContainerBL.MainRow.Capacity;
            }

            //aktywowanie odpowiednich kontrolek w zaleznosci od typu formatki
            switch (formType)
            {
                case ContainerFormTypeEnum.Edit:
                    InitContainerParameterControls(true);
                    InitContainerStateControls(false);
                    InitHistoryControls(false);
                    comboContainerType.Enabled = false;
                    break;
                case ContainerFormTypeEnum.New:
                    InitContainerParameterControls(true);
                    InitContainerStateControls(false);
                    InitHistoryControls(false);
                    break;
                case ContainerFormTypeEnum.Update:
                    InitContainerParameterControls(false);
                    InitContainerStateControls(true);
                    InitHistoryControls(true);
                    break;
                case ContainerFormTypeEnum.View:
                    InitContainerParameterControls(false);
                    InitContainerStateControls(false);
                    InitHistoryControls(false);
                    break;
            }

            _ContainerBL.ContainerDataSet.Container.ContainerRowChanged += new ContainerDataSet.ContainerRowChangeEventHandler(Container_ContainerRowChanged);

            return true;   
        }

        void Container_ContainerRowChanged(object sender, ContainerDataSet.ContainerRowChangeEvent e)
        {
            bool hasChanges = _ContainerBL.ContainerDataSet.HasChanges();
            if (hasChanges)
            {
                try
                {
                    //_ContainerBL.Save();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void BindControls()
        {
            bindingSource1.DataSource = _ContainerBL.MainRow;

            BindControl(tbContainerName, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.ContainerNameColumn);
            BindControl(tbContainerNumber, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.ContainerNumberColumn);
            BindControl(comboContainerType, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.ContainerTypeColumn);
            BindControl(tbLiquidName, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.LiquidNameColumn);
            BindControl(tbCapacityDelivered, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.CapacityDeliveredColumn);
            BindControl(tbCapacityDeliveredDate, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.CapacityDeliveredDateColumn);
            BindControl(tbCurrentHeigh, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.CurrentHeightColumn);
            BindControl(tbCurrentCapacity, _ContainerBL.ContainerDataSet.Container, _ContainerBL.ContainerDataSet.Container.CurrentCapacityColumn);

            //ContainerKindEnum list = ContainerKindEnum.Barrel;
            //comboContainerType.Init(list, typeof(ContainerKindEnum));

            comboContainerType.DataSource = _ContainerBL.ContainerTypeBL.MainDataTable;
            comboContainerType.ValueMember = "ContainerTypeId";
            comboContainerType.DisplayMember = "ContainerTypeName";

            _ContainerBL.ContainerTypeBL.MainRow = (ContainerDataSet.ContainerTypeRow)_ContainerBL.ContainerTypeBL.MainDataTable.Select(_ContainerBL.ContainerTypeBL.MainDataTable.ContainerTypeIdColumn.ColumnName + " = '" + comboContainerType.SelectedValue + "'")[0];
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

        #endregion

        #region walidacja i save

        const string FIELD_REQUIRED = "Pole nie może być puste.";

        private bool ValidateControlsForUpdate()
        {
            bool result = true;


            //Poziom cieczy
            if (_ContainerBL.ContainerTypeBL.MainRow.Height < tbCurrentHeigh.Value)
            {
                result = false;
                errorProvider1.SetError(tbCurrentHeigh, "Aktualny poziom musi być mniejszy niż wysokość zbiornika.");
            }
            else
                errorProvider1.SetError(tbCurrentHeigh, "");

            if (_ContainerBL.ContainerTypeBL.MainRow.Capacity< tbCurrentCapacity.Value || tbCurrentCapacity.Value < 0)
            {
                result = false;
                errorProvider1.SetError(tbCurrentCapacity, "Aktualna ilość musi być mniejsza niż pojemność zbiornika.");
            }
            else
                errorProvider1.SetError(tbCurrentCapacity, "");

            if (result)
                errorProvider1.Clear();

            return result;
        }

        public bool ValidateInsert()
        {
            bool result = true;

            //Nazwa cieczy
            if (tbContainerName.Text == string.Empty)
            {
                result = false;
                errorProvider1.SetError(tbContainerName, FIELD_REQUIRED);
            }
            else
                errorProvider1.SetError(tbContainerName, "");

            //Nazwa cieczy
            if (tbLiquidName.Text == string.Empty)
            {
                result = false;
                errorProvider1.SetError(tbLiquidName, FIELD_REQUIRED);
            }
            else
                errorProvider1.SetError(tbLiquidName, "");

            if (_containerNumberList.Contains((int)tbContainerNumber.Value) && _formType == ContainerFormTypeEnum.New)
            {
                result = false;
                errorProvider1.SetError(tbContainerNumber, string.Format("Podany nr jest juz uzywany."));
            }
            else
                errorProvider1.SetError(tbContainerNumber, string.Format(""));

            return result;
        }

        private bool _IsSaved = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = true;

            //CalculateCurrentStates();

            switch (_formType)
            {
                case ContainerFormTypeEnum.New:
                    result = ValidateInsert();
                    break;
                case ContainerFormTypeEnum.Edit:
                    result = ValidateInsert();
                    break;
                case ContainerFormTypeEnum.Update:
                    result = ValidateControlsForUpdate();
                    break;
            }

            if (!result)
            {
                MessageBox.Show(string.Format("Weryfikacja danych zakończyła się niepowodzeniem.\nPopraw błędy i spróbuj ponownie."), "Omega", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _ContainerBL.MainRow.ContainerName = tbContainerName.Text;
                _ContainerBL.MainRow.LiquidName = tbLiquidName.Text;
                _ContainerBL.Save();
                if (_formType == ContainerFormTypeEnum.Update)
                    _ContainerBL.AddMeasurements();
                MessageBox.Show("Dane zostały zapisane.", "Omega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _IsSaved = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Wystąpiły błędy podczas zapiywania danych. {0}",ex.Message), "Omega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ustawienie dostępności kontrolek dla różynych trybów okien

        private void InitContainerParameterControls(bool enable)
        {
            tbContainerName.ReadOnly = !enable;
            tbContainerNumber.ReadOnly = !enable;
            comboContainerType.Enabled = enable;
            tbLiquidName.ReadOnly = !enable;
            cbIsGrowing.Enabled = enable;

            if (_formType == ContainerFormTypeEnum.Edit)
                tbContainerNumber.ReadOnly = true;
        }

        private void InitContainerStateControls(bool enable)
        {
            tbCurrentCapacity.ReadOnly = !enable;
            tbCurrentHeigh.ReadOnly = !enable;
            tbCurrentDistance.ReadOnly = !enable;
        }

        private void InitHistoryControls(bool enable)
        {
            tbCapacityDelivered.ReadOnly = !enable;
            tbCapacityDeliveredDate.ReadOnly = !enable;
        }

        #endregion

        #region uaktualnianie stanów zbiorników on-line

        private bool isUpdating = false;

        private void tbCurrentDistance_ValueChanged(object sender, EventArgs e)
        {
            if(!isUpdating)
                CalculateCurrentStates();
        }

        private void tbCurrencyHeigh_ValueChanged(object sender, EventArgs e)
        {
            if(!isUpdating)
                CalculateCurrentStates();
        }

        private void CalculateCurrentStates()
        {
            if (isInitializing)
            {
                return;
            }

            isUpdating = true;
            _ContainerBL.MainRow.CurrentHeight = Convert.ToInt32((int)_ContainerBL.ContainerTypeBL.MainRow.Height) - Convert.ToInt32(tbCurrentDistance.Value);
            tbCurrentHeigh.Value = _ContainerBL.ContainerTypeBL.MainRow.Height - tbCurrentDistance.Value;
            tbCurrentDistance.Value = _ContainerBL.ContainerTypeBL.MainRow.Height - tbCurrentHeigh.Value;
            _ContainerBL.CalculateVa((int)tbCurrentDistance.Value);
            tbCurrentCapacity.Value = _ContainerBL.MainRow.CurrentCapacity;

            isUpdating = false;
        }

        private void CalculateCurrentStates2()
        {
            isUpdating = true;
            if (_ContainerBL.MainRow.ContainerType == (int)ContainerKindEnum.Barrel)
                _ContainerBL.MainRow.CurrentHeight = Convert.ToInt32((int)tbCurrentCapacity.Value) * 4;

            tbCurrentHeigh.Value = _ContainerBL.MainRow.CurrentHeight;
            tbCurrentDistance.Value = _ContainerBL.ContainerTypeBL.MainRow.Height - tbCurrentHeigh.Value;
            isUpdating = false;
        }

        private void tbCurrentCapacity_ValueChanged(object sender, EventArgs e)
        {
            if (!isInitializing && !isUpdating)
                CalculateCurrentStates2();
        }

        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_formType == ContainerFormTypeEnum.Edit || _formType == ContainerFormTypeEnum.New)
            {
                if (_formType == ContainerFormTypeEnum.New)
                    _ContainerBL.CalculateVa((int)tbCurrentDistance.Value);

                _ContainerBL.MainRow.MaxHeight = _ContainerBL.ContainerTypeBL.MainRow.Height;
            }
            else if (_formType == ContainerFormTypeEnum.Update)
            {

                _ContainerBL.CalculateVa((int)tbCurrentDistance.Value);
            }

            tbCurrentCapacity.Value = _ContainerBL.MainRow.CurrentCapacity;
        }

        private void ContainerRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!_IsSaved)
                if (MessageBox.Show("Wszystkie wprowadzone zmiany zostaną anulowane. Kontynuować?", "Omega", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }

        private void comboContainerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboContainerType.SelectedValue.GetType() != typeof(long)) return;

            _ContainerBL.ContainerTypeBL.MainRow = (ContainerDataSet.ContainerTypeRow)_ContainerBL.ContainerTypeBL.MainDataTable.Select(_ContainerBL.ContainerTypeBL.MainDataTable.ContainerTypeIdColumn.ColumnName + " = '" + comboContainerType.SelectedValue + "'")[0];
            _ContainerBL.MainRow.ContainerType = _ContainerBL.ContainerTypeBL.MainRow.ContainerTypeId;

            if ((isInitializing && _formType != ContainerFormTypeEnum.New)) return;

            switch ((ContainerKindEnum)_ContainerBL.ContainerTypeBL.MainRow.ContainerKind)
            {
                //dla beczki domyślne wartości - nie do edycji
                case ContainerKindEnum.Barrel:
                    _ContainerBL.MainRow.MaxHeight = ContainerTypeBL.DEFAULT_HEIGHT;

                    break;
                case ContainerKindEnum.Other:
                    _ContainerBL.MainRow.MaxHeight = 0;

                    break;
                default:
                    _ContainerBL.MainRow.MaxHeight = 0;

                    break;
            }
        }

        private void ContainerRecordForm_Shown(object sender, EventArgs e)
        {
            tbCurrentDistance.Value = _ContainerBL.ContainerTypeBL.MainRow.Height - _ContainerBL.MainRow.CurrentHeight;
            isInitializing = false;
        }

    }
}