namespace Cient_App_for_Warehouse
{
    public interface IEventWriter
    {
        bool IsFileExists { get; set; }
        void CreateFile();
        void WriteToFile(User user);
    }
}