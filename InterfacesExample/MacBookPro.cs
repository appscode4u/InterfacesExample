using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class MacBookPro : Mac
    {
        public bool USBC20 { get; set; }
        public MacBookPro(string serialNo, bool usbC20) : base(serialNo)
        {
            USBC20 = usbC20;
        }
    }
}
