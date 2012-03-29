using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Omega
{
    public class TransmissionCotroller
    {
        private RS232 _rs232;

        //private List<ContainerDataSet.ContainerRow> _listContainer;
        private List<long> _listContainerNr;
        //private ContainerDataSet.ContainerRow _currentContainer;
        private long _currentContainerNr;
        private MeasurementBL _measurementBL = new MeasurementBL();
        private ContainerBL _containerBL = new ContainerBL();
        private DataView _conatinerDataView;

        /// <summary>
        /// Rozpoczęcie sczytywania stanów zbiorników przez COM
        /// </summary>
        public void Init()
        {
            _measurementBL = new MeasurementBL();
            _measurementBL.Init();

            _containerBL = new ContainerBL();
            _containerBL.Init();

            SystemConfigBL configBL = new SystemConfigBL();
            configBL.Init();
            configBL.FillRecord();

            _rs232 = new RS232();
            _rs232.ReadTimeOut = 1000;
            _rs232.DataReceivedEvent += new RS232.DataReceived(_rs232_DataReceivedEvent);
            _rs232.CanReadExisting = true;
            _rs232.Open(configBL.MainRow.ComName, 1200);
        }

        private void CreateContainerDataView(List<long> listContainerNr)
        {
            string rowFilter = _containerBL.MainDataTable.ContainerIdColumn.ColumnName + " in (";

            foreach (long id in listContainerNr)
            {
                rowFilter += id.ToString() + ",";
            }

            rowFilter = rowFilter.TrimEnd(',');

            rowFilter += ")";

            _conatinerDataView = new DataView(_containerBL.MainDataTable, rowFilter, "", DataViewRowState.CurrentRows);
        }

        public DataView ContainerDataView
        {
            get { return _conatinerDataView; }
        }

        public bool Start(List<long> listContainerNr)
        {
            _containerBL.FillList();
            CreateContainerDataView(listContainerNr);

            _rs232.Start();

            _listContainerNr = listContainerNr;
            if (_listContainerNr.Count == 0)
                return false;

            _currentContainerNr = _listContainerNr[0];

            SendContainerRequest();

            return true;
        }

        //2DEL
        //public bool Start(List<ContainerDataSet.ContainerRow> listContainer)
        //{
        //    _rs232.Start();

        //    _listContainer = listContainer;
        //    if (_listContainer.Count == 0)
        //        return false;

        //    _currentContainer = _listContainer[0];

        //    SendContainerRequest();

        //    return true;
        //}

        private bool ValidateData(string data, out int distance)
        {
            distance = 0;
            //TODO - poprawic jak tata poprawi transmisje
            string d = data.Substring(3).TrimEnd('K');

            if (d == "????????")
            {
                distance = -9999;
                return true;
            }

            string strD1 = d.Substring(0, 4);
            string strD2 = d.Substring(4, d.Length - 4);

            int d1 = 0, d2 = 0;
            if (!Int32.TryParse(strD1, out d1) || !Int32.TryParse(strD2, out d2))
                throw new Exception(string.Format("Błąd transmisji: Odebrano dane o odleglosci nie bedace liczba\nZawartość pakietu danych z pilota [{0}]", data));

            distance = d1;

            if (d1 == d2)
                return true;
            else
                return false;
        }

        void _rs232_DataReceivedEvent(string data, bool isManual)
        {
            // jesli poprane (liczby rowne) to zapis i przejscie do nastepnego zbiornika
            // jesli nie to powtorka
            // TODO - cos zrobic zeby sie nie zapetlic (ciagle zle porownanie)
            int distance = 0;
            if (ValidateData(data, out distance))
            {
                //dodanie iformacji do DS-a
                _containerBL.MainRow = GetContainerRow(_currentContainerNr);
                _containerBL.CalculateVa(distance);

                //usuniecie zbiornika z listy
                //_listContainer.Remove(_currentContainer);
                _listContainerNr.Remove(_currentContainerNr);
                // jesli sczytano wszystko to wylaczam transmisje rs232
                if (_listContainerNr.Count == 0)
                {
                    //_rs232.Stop();
                    OnEndTransmission();

                    return;
                }

                //ustalenie nowego zbiornika jako aktualny
                //_currentContainer = _listContainer[0];
                _currentContainerNr = _listContainerNr[0];
            }

            //wyslanie zapytania o zbiornik
            SendContainerRequest();
        }

        private void SendContainerRequest()
        {
            //wysylanie zapytania
            string req = string.Format("Z{0:00}", GetContainerRow(_currentContainerNr).ContainerNumber);
            _rs232.Send(req);
        }

        private ContainerDataSet.ContainerRow GetContainerRow(long containerId)
        {
            ContainerDataSet.ContainerRow[] rows = (ContainerDataSet.ContainerRow[])_containerBL.MainDataTable.Select(_containerBL.MainDataTable.ContainerIdColumn.ColumnName + " = " + containerId);
            if (rows.Length != 1)
                throw new Exception("Błąd danych podczas transmisji PC->UMP. Nie znaleziono zbiornika o identyfikatorze :" + containerId);

            _containerBL.ContainerTypeBL.MainRow = (ContainerDataSet.ContainerTypeRow)_containerBL.ContainerTypeBL.MainDataTable.Select(_containerBL.ContainerTypeBL.MainDataTable.ContainerTypeIdColumn.ColumnName + " = '" + rows[0].ContainerType + "'")[0];

            return rows[0];
        }

        public delegate void EndTransmission();
        public event EndTransmission EndTransmissionEvent;

        private void OnEndTransmission()
        {
            if (EndTransmissionEvent != null)
                EndTransmissionEvent();
        }

        public void Accept()
        {
            foreach (ContainerDataSet.ContainerRow containerRow in _containerBL.MainDataTable.Select())
            {
                _measurementBL.AddNewMeasurement(containerRow.ContainerId,containerRow.CurrentHeight, containerRow.CurrentCapacity);
            }
            _containerBL.Save();
            _measurementBL.Save();

            _containerBL.ContainerDataSet.Container.Clear();
        }

        public void CancelMeasurement()
        {
            _measurementBL.MeasurementDataSet.Measurement.Clear();
        }

        public void Stop()
        {
            _rs232.Stop();
        }

        #region TEST
        public void TestInit()
        {
            _rs232 = new RS232();
            _rs232.ReadTimeOut = 1000;
            _rs232.DataReceivedEvent += new RS232.DataReceived(_rs232_DataReceivedEventTest);
            _rs232.CanReadExisting = true;
            _rs232.Open("COM1", 1200);
            _rs232.Start();
        }

        void _rs232_DataReceivedEventTest(string data, bool isManual)
        {

        }
        #endregion
    }
}
