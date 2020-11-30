﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class MacBook : Pendrive
    {   
        public MacBook()
        {/*
            File f = LoadFile(@"c:\test\test.txt");
            Console.WriteLine($"nazwa pliku: {f.NAME}");
            WriteData(f, "cont1");
            WriteData(f, "cont2");
            Console.WriteLine("Is content of file {0} deleted? {1}",f.NAME, DeleteContent(f));
       */
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