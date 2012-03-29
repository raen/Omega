using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
namespace Omega
{
    class RS232
    {
        private SerialPort _serialPort;
        private BackgroundWorker _worker;

        public RS232()
        {
            _serialPort = new SerialPort();
            //_serialPort.ReadTimeout = 1000;
            _ReadToString = "K";
            _ReadFromString = "K";// string.Empty;
            _CanReadExisting = false;
            _worker = new BackgroundWorker();
            _worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            _worker.ProgressChanged += new ProgressChangedEventHandler(_worker_ProgressChanged);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_worker_RunWorkerCompleted);
            _worker.WorkerSupportsCancellation = true;
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!_worker.CancellationPending)
            {
                try
                {
                    if (_serialPort.IsOpen)
                    {
                        string data = string.Empty;
                        // czytanie do okreslonego znaku
                        if (!_CanReadExisting)
                        {
                            data = _serialPort.ReadTo(_ReadToString);

                            string dataFrom = data.Substring(0, _ReadFromString.Length);
                            if(_ReadFromString == string.Empty || _ReadFromString == dataFrom)
                                OnDataReceived(data.Substring(_ReadFromString.Length),false);
                        }
                        // czytanie wszystkiego co przyjdzie
                        else
                        {
                            data = _serialPort.ReadExisting();
                            if (!string.IsNullOrEmpty(data))
                                OnDataReceived(data,false);
                        }
                    }
                }
                catch (TimeoutException ex1)
                {
                    throw new TimeoutException("Nie odczytano dancyh z RS232 w okreslonym limicie czasu");
                }
                catch (System.IO.IOException ex2)
                {
                }
                
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Otwarcie i konfiguracja portu RS232
        /// </summary>
        /// <param name="portName">Nazwa portu: COM1, COM2, itd.</param>
        /// <param name="baudRate">prędkość transmisji w bodach (najczęściej 9600)</param>
        /// <param name="parity">bit parzystości</param>
        /// <param name="dataBits">liczba bitow danych od 5 do 8</param>
        /// <param name="stopBits">liczba bitow stopu</param>
        /// <returns></returns>
        public bool Open(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            // jesli nie ma zadnego portu RS232
            if (SerialPort.GetPortNames().Length == 0)
                return false;
            
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = dataBits;
            _serialPort.StopBits = stopBits;


            //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Open port {0} rate {1}", portName, baudRate);

            try
            {
                _serialPort.Open();
            }
            catch (Exception ex) 
            {
                //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Open error {0}", ex.Message);
                //MessageBox.Show(e.Message);
                return false;
            }

            //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Port {0} opened", portName);

            return true;
        }

        /// <summary>
        /// Otwarcie i konfiguracja portu RS232
        /// </summary>
        /// <param name="portName">Nazwa portu: COM1, COM2, itd.</param>
        /// <param name="baudRate">prędkość transmisji w bodach (najczęściej 9600)</param>
        /// <returns></returns>
        public bool Open(string portName, int baudRate)
        {
            return Open(portName, baudRate, Parity.None, 8, StopBits.One);
        }

        public void Close()
        {
            if (_serialPort.IsOpen)
            {
                //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Port {0} Close", _serialPort.PortName);
                _serialPort.Close();
            }
            
        }

        /// <summary>
        /// uruchamianie watku nasluchujacego na RS232
        /// </summary>
        /// <returns></returns>
        public void Start()
        {
            //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Port {0} Start", _serialPort.PortName);
            //if(!_worker.IsBusy)
                _worker.RunWorkerAsync();
        }

        /// <summary>
        /// wstrzymanie watku nasluchujacego
        /// </summary>
        public void Stop()
        {
            //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "Port {0} Stop", _serialPort.PortName);
            //if(!_worker.CancellationPending)
                _worker.CancelAsync();

        }

        public delegate void DataReceived(string data, bool isManual);
        public event DataReceived DataReceivedEvent;

        private void OnDataReceived(string data, bool isManual)
        {

            //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "{0} received {1}", _serialPort.PortName, data);

            if(DataReceivedEvent != null)
                DataReceivedEvent(data,isManual);
        }

        public int ReadTimeOut
        {
            get { return _serialPort.ReadTimeout; }
            set { _serialPort.ReadTimeout = value; }
        }

        private string _ReadToString;
        public string ReadToString
        {
            get { return _ReadToString; }
            set { _ReadToString = value; }
        }

        private string _ReadFromString;
        public string ReadFromString
        {
            get { return _ReadFromString; }
            set { _ReadFromString = value; }
        }

        public void Send(string data)
        {
            if (_serialPort.IsOpen)
            {
                //Flexlib.Common.FlexTrace.WriteLineFrmWithSender(this, "{0} send {1}", _serialPort.PortName, data);
                _serialPort.Write(data);
            }
        }

        private bool _CanReadExisting;
        public bool CanReadExisting
        {
            get { return _CanReadExisting; }
            set { _CanReadExisting = value; }
        }
    }
}
