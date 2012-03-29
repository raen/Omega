using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyLib.DL
{
    abstract public class DataManagerBase
    {
        public abstract DataSet MainDataSet { get; }
    }
}
