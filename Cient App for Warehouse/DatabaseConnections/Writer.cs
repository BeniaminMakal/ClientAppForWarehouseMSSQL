using Cient_App_for_Warehouse.GetDataFromDatabase;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Cient_App_for_Warehouse
{
    public class EventWriter : EventArgs
    {
        
    }

    public class LoginWriter : IWriter
    {

        private string path = Path.Combine(Environment.CurrentDirectory, @"Data\Log.txt");
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

        public void WriteToFile<T, Y>(T first, Y secound)
        {
            if (IsFileExists != true)
            {
                CreateFile();
            }
            
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine($"{DateTime.Now} Logged user: {first}");

            }
        }

        public void WriteToFile<T>(T first)
        {
            if (IsFileExists != true)
            {
                CreateFile();
            }

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine($"{DateTime.Now} Logged user: {first}");

            }
        }

        public class UserEventWriter : IWriter
        {
            private string path = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\ClientAppForWarehouseMSSQL\Log.txt";
            public bool IsFileExists { get ; set ; }

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

            public void WriteToFile<T, Y>(T first, Y secound)
            {
               
            }

            public void GotPriceOfBeer(object source, GetDataFromDatabaseEventArgs e)
            {
                WriteToFile(@"{e.LogInformation.UserName} got info about: {e.LogInformation.ProductName} at {DateTime.Now}"); 
            }

            public void WriteToFile<T>(T first)
            {
                throw new NotImplementedException();
            }
        }

    }
}