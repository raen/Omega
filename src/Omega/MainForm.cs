using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class MainForm : Form
    {
        private TransmissionCotroller _transmissionCotroler;

        public MainForm()
        {
            InitializeComponent();

            ContainerBL containerBL = new ContainerBL();
            containerBL.Init();
            //_containerDataTable = containerBL.FillList();

            gridMeasures.DataSource = new DataView(containerBL.ContainerDataSet.Container);
            //gridMeasures.DataSource = new DataView(_containerDataTable, "0=1", "", DataViewRowState.CurrentRows);

            //InitNewTransmission(false);

            foreach (DataColumn dataColumn in containerBL.ContainerDataSet.Container.Columns)
            {
                if (dataColumn == containerBL.ContainerDataSet.Container.ContainerNameColumn || dataColumn == containerBL.ContainerDataSet.Container.ContainerNumberColumn || dataColumn == containerBL.ContainerDataSet.Container.CurrentHeightColumn)
                    continue;

                gridMeasures.InitColumnsAsInvisible(dataColumn);
            }
        }

        #region obluga menu

        private void miRegistry_Click(object sender, EventArgs e)
        {
            RegistryForm registryForm = new RegistryForm();
            registryForm.Init();
            registryForm.ShowDialog();
        }

        private void miContainer_Click(object sender, EventArgs e)
        {
            ContainerListForm listForm = new ContainerListForm();
            listForm.Init();
            listForm.ShowDialog();
        }

        private void miConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationForm form = new ConfigurationForm();
            form.ShowDialog();
        }


        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void miContainerType_Click(object sender, EventArgs e)
        {
            ContainerTypeListForm listForm = new ContainerTypeListForm();
            listForm.Init();
            listForm.ShowDialog();
        }

        #endregion

        #region obsługa transmisji

        private ContainerDataSet.ContainerDataTable _containerDataTable;

        private WaitForm _waitForm;

        private void btnTransmission_Click(object sender, EventArgs e)
        {
            //TODO jesli nie zapisany poprzedni stan to komunikat, ze utraci
            //InitNewTransmission();

            _transmissionCotroler = new TransmissionCotroller();
            _transmissionCotroler.Init();
            _transmissionCotroler.EndTransmissionEvent += new TransmissionCotroller.EndTransmission(_transmissionCotroler_EndTransmissionEvent);
            _waitForm = new WaitForm();

            ContainerChooseForm contChooseForm = new ContainerChooseForm();
            contChooseForm.Init();
            if (contChooseForm.ShowDialog() == DialogResult.OK)
            {

                if (contChooseForm.CheckedContainers.Count == 0)
                {
                    MessageBox.Show("Nie wybrano żadnego zbiornika");
                    return;
                }

                _waitForm = new WaitForm();
                _waitForm.Show();

                _transmissionCotroler.Start(contChooseForm.CheckedContainers);
            }
        }

        private delegate void EndTransmissionCallback();
        void _transmissionCotroler_EndTransmissionEvent()
        {
            _transmissionCotroler.Stop();

            if (_waitForm.InvokeRequired)
            {
                EndTransmissionCallback d = new EndTransmissionCallback(_transmissionCotroler_EndTransmissionEvent);
                this.Invoke(d, new object[] { });
            }
            else
            {
                _waitForm.Close();
                _waitForm.Dispose();
                //podpiecie grida
                gridMeasures.DataSource = _transmissionCotroler.ContainerDataView;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _transmissionCotroler.Accept();
            
            MessageBox.Show("Dane zostały zapisane w historii pomiarów");
        }

        private void InitNewTransmission()
        {
            _containerDataTable.Clear();

            ContainerBL containerBL = new ContainerBL();
            containerBL.Init();
            _containerDataTable = containerBL.FillList();

            gridMeasures.DataSource = new DataView(_containerDataTable, "0=1", "", DataViewRowState.CurrentRows);
        }

        #endregion

        #region TEST

        private void button1_Click(object sender, EventArgs e)
        {
            TransmissionCotroller con = new TransmissionCotroller();
            con.TestInit();
        }

        #endregion

    }
}