using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {

          //some tests
            MacBook mac = new MacBook("abc 123");
            //Load File
            File file = mac.LoadFile(@"c:\test\test.txt");
            //Write some data
            mac.WriteData(file, "test content");
            //Replace data in file
            mac.WriteData(file, "alter data");
            //clear data in file and display message
            Console.WriteLine("Is content of file {0} deleted? {1}", file.NAME, mac.DeleteContent(file));
          
         //
            Console.WriteLine();
        }
    }
}
