namespace Cient_App_for_Warehouse
{
    public interface IWriter
    {
        bool IsFileExists { get; set; }
        void CreateFile();
        void WriteToFile(User user);
    }
}