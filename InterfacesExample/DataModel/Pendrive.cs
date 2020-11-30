using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    class Pendrive : IUsbSupported
    {
        public string driveLetter { get; set; }
        public bool isPluggedIn { get; set; } = false;


        /// <summary>
        /// Method used for clear content of entire file
        /// </summary>
        /// <param name="f">It is file object</param>
        /// <returns>true / false as an operation success status</returns>
        public bool DeleteContent(File f)
        {
            Console.WriteLine("I delete file {0} from method in Pendrive class", f.NAME);
            return true;
        }

        /// <summary>
        /// Method used for return opened file in path localization
        /// </summary>
        /// <param name="fullPath">whole path of the file</param>
        /// <returns>return a File object after loading</returns>
        public File LoadFile(string fullPath)
        {
            Console.WriteLine("I load new file from path: {0} from method in Pendrive class", fullPath);
            string fName = fullPath.Split(@"\")[fullPath.Split(@"\").Length - 1];
            return new File(fullPath, fName);
        }

        /// <summary>
        /// Method used for Write data in to connected file
        /// </summary>
        /// <param name="f">file name</param>
        /// <param name="content">string content</param>
        /// <returns>true / false as an operation succes status</returns>
        public bool WriteData(File f, string content)
        {
            Console.WriteLine($"Pendrive's method WriteData, old data: '{f.CONTENT}', new data: '{content}'");
            f.CONTENT = content;
            return true;
        }

        /// <summary>
        /// Method to test if a file exists in provided location
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool FileExists(string path)
        {
            return true;
        }

    }
}
