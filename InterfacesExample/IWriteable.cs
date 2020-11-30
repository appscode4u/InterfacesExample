namespace InterfacesExample
{
    interface IWriteable
    {
        bool WriteData(File f, string content);
        bool DeleteContent(File f);
    }
}
