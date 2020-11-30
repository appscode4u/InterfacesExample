using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    interface IUsbSupported : IReadable,IWriteable
    {
        //nothing new here only joined inhererited model of methods 
        //from interfaces IReadable and IWritable
    }
}
