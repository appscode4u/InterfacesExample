using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class MacBook : Mac
    {
        public int fingerPrintReaderID { get; set; }
        public MacBook(string serialNo,int fingerPid) : base(serialNo)
        {
            fingerPrintReaderID = fingerPid;
        }
    }
}
