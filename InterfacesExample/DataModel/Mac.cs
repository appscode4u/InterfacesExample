using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class Mac : Pendrive
    {
        public string serialNumber { get; }
        public string cpu { get; set; }
        public string screenSize { get; set; }
        public double memory { get; set; }

        public Mac(string serialNo)
        {
            serialNumber = serialNo;
        }

        /// <summary>
        /// Method used for connect media to the computer
        /// </summary>
        public void PlugIn()
        {
            isPluggedIn = true;
            driveLetter = "X:";
            Console.WriteLine("Pendrive has been plugged-in");
        }

        /// <summary>
        /// Method used for unconnect media from the computer
        /// </summary>
        public void PlugOut()
        {
            isPluggedIn = false;
            driveLetter = "";
            Console.WriteLine("Pendrive has been plugged-out");
        }

    }
}
