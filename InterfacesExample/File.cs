using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class File
    {
        public string PATH { get; }

        public string CONTENT { get; set; }

        public File(string path)
        {
            PATH = path;
        }
    }
}
