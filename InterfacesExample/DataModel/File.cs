namespace InterfacesExample
{
    class File
    {
        public string PATH { get; }
        public string NAME { get; set; }
        public string CONTENT { get; set; }

        public File(string path, string name)
        {
            PATH = path;
            NAME = name;
        }
    }
}
