using System.IO;
using System.Runtime.InteropServices;

namespace Cient_App_for_Warehouse
{
    public class EventWriter : IEventWriter
    {
        private string path = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\ClientAppForWarehouseMSSQL";
        public bool IsFileExists { get; set; }
        public void CreateFile()
        {
            if (IsFileExists == true)
            {
                return;
            }

            
            StreamWriter newWriter = new StreamWriter(path);
            newWriter.WriteLine("test");

            IsFileExists = true;
        }

        public void WriteToFile(User user)
        {
            if (IsFileExists != true)
            {
                CreateFile();
            }



        }
    }
}