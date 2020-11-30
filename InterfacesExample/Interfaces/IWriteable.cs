namespace InterfacesExample
{
    interface IWriteable
    {
        public bool WriteData(File f, string content);
        public bool DeleteContent(File f);
    }
}
