using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class MacBookAir : Mac
    {
        public string WIFI5G { get; set; }
        public MacBookAir(string serialNo, string wifi5g) : base(serialNo)
        {
            WIFI5G = wifi5g;
        }
    }
}
