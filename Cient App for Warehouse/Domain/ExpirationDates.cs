using System;

namespace Cient_App_for_Warehouse.Domain
{
    public interface IExpirationDates
    {
        int ExpirationDateID { get;  }
        string ProductName { get; }
        string SerialNumber { get;  }
        DateTime ExpiartionDate { get;  }
    }

    public class ExpirationDates : IExpirationDates
    {
        public int ExpirationDateID { get; private set; }
        public string ProductName { get; private set; }
        public string SerialNumber { get; private set; }
        public DateTime ExpiartionDate { get; private set; }
    }
}
