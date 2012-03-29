using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Omega
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        MeasurementBL _MeasurementBL = null;

        public void Init()
        {
            _MeasurementBL = new MeasurementBL();
            _MeasurementBL.Init();

            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);

            gridRegistry.DataSource = _MeasurementBL.MeasurementDataSet.vMeasurement;

            Fill();
        }


        public void Fill()
        {
            _MeasurementBL.Fill(dtFrom.Value, dtTo.Value);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Fill();
        }
    }
}