using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class ConfigurationForm : Form
    {

        private SystemConfigBL _configBL = null;

        public ConfigurationForm()
        {
            InitializeComponent();

            // dodawanie dostępnych portow do comboboxa
            String[] arrPorts = System.IO.Ports.SerialPort.GetPortNames();
            List<string> s = new List<string>();
            foreach (string portName in arrPorts)
                s.Add(portName);

            s.Sort();
            foreach (string port in s)
                cbComNbr.Items.Add(port);

            _configBL = new SystemConfigBL();
            _configBL.Init();
            _configBL.FillRecord();
            
            // wczytywanie aktualnie ustawionego (jako widoczny)
            cbComNbr.Text = _configBL.MainRow.ComName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbComNbr.Text != string.Empty)
            {
                _configBL.MainRow.ComName = cbComNbr.Text;
                _configBL.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}