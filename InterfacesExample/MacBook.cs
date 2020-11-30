using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class MacBook : Pendrive
    {
        public string serialNumber { get; }
        public MacBook(string serialNo)
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
