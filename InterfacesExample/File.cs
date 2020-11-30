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
