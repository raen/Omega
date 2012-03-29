using System;
using System.Collections.Generic;
using System.Text;

namespace Omega.MyLib.DL
{
    public class SQLSelect
    {
        public SQLSelect(string from)
        {
            _From = from;
        }

        public SQLSelect(string from, string where) : base()
        {
            _From = from;
            _Where = where;
        }

        private string _From;
        public string From
        {
            set { _From = value; }
            get { return _From; }
        }

        private string _Where;
        public string Where
        {
            set { _Where = value; }
            get { return _Where; }
        }
        
    }
}
