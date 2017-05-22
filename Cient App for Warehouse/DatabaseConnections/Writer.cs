using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Cient_App_for_Warehouse
{
    public class EventWriter : EventArgs
    {
        
    }

    public class Writer : IWriter
    {

        private string path = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\ClientAppForWarehouseMSSQL\Log.txt";
        public bool IsFileExists { get; set; }
        public void CreateFile()

        {
            IsFileExists = File.Exists(path);

            if (IsFileExists == true)
            {
                return;
            }

            using (Stream stream = File.Create(path))

            IsFileExists = true;
        }

        public void WriteToFile(User user)
        {
            if (IsFileExists != true)
            {
                CreateFile();
            }

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine($"{DateTime.Now} Logged user: {user.Login}");

            }
        }

    }
}