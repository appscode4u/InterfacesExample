using System;
using System.Collections.Generic;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of computers
            List<Mac> computers = new List<Mac>();

          //some tests of one computer
            Mac mac = new MacBook("abc 123",3);
            MacBook mc = (MacBook)mac;
            //computer class and unique parameter fingerPrintReaderID only in MacBook's
            Console.WriteLine("computer from class: " + mac.GetType().Name+" fingerPrintID: " + mc.fingerPrintReaderID);
            //Load File
            File file = mac.LoadFile(@"c:\test\test.txt");
            //Write some data
            mac.WriteData(file, "test content");
            //Replace data in file
            mac.WriteData(file, "alter data");
            //clear data in file and display message
            Console.WriteLine("Is content of file {0} deleted? {1}", file.NAME, mac.DeleteContent(file));

            //create 10 different computers of 3 types Mac
            computers = getComputers();

            //display some main details
            displayComputersDetails(computers);

            Console.WriteLine();
        }
        private static List<Mac> getComputers()
        {
            List<Mac> tmpMacList = new List<Mac>();
            tmpMacList.Add(new MacBookAir("Air765WWW", "y5-44x4-33t"));
            tmpMacList.Add(new MacBook("abc123", 3));
            tmpMacList.Add(new MacBookPro("pro444ddd", true));
            tmpMacList.Add(new MacBookAir("AirHHHH123", "555-444-333"));
            tmpMacList.Add(new MacBook("113ss", 77));
            tmpMacList.Add(new MacBookPro("pro777777", false));
            tmpMacList.Add(new MacBookAir("Airzzzz999", "125-4gg4-33"));
            tmpMacList.Add(new MacBook("KK9484LJJ", 12));
            tmpMacList.Add(new MacBookAir("AirpppHHHuuu111", "bb5-y74-3lv"));
            tmpMacList.Add(new MacBookPro("pro11abc1", true));

            return tmpMacList;
        }
        private static void displayComputersDetails(List<Mac> computers)
        {
            foreach (var comp in computers)
            { 
                switch (comp.GetType().Name)
                {
                    case "MacBook":
                        Console.WriteLine($"Class: MacBook, Serial: {comp.serialNumber} fingerPrintID: {((MacBook)comp).fingerPrintReaderID}");
                        break;
                    case "MacBookAir":
                        Console.WriteLine($"Class: MacBookAir, Serial: {comp.serialNumber} WIFI 5G serial: {((MacBookAir)comp).WIFI5G}");
                        break;
                    case "MacBookPro":
                        Console.WriteLine($"Class: MacBookPro, Serial: {comp.serialNumber} USB C on board?: {((MacBookPro)comp).USBC20}");
                        break;
                }
            }
        }
    }
}
