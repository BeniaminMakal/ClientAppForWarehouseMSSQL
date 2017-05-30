using System;

namespace Cient_App_for_Warehouse
{
    public interface ITradingPartners
    {
        Guid PartnerID { get; }
        string PartnerName { get; }
        string NIP { get; }
        string City { get; }
        string Address { get; }
        string PostalCode { get; }
        string Telephone { get; }
        string Email { get; }
        string WWW { get; }
        string CustomerType { get; }
    }

    public class TradingPartners : ITradingPartners
    {
        public Guid PartnerID { get; private set; }

        public string PartnerName { get; private set; }

        public string NIP { get; private set; }

        public string City { get; private set; }

        public string Address { get; private set; }

        public string PostalCode { get; private set; }

        public string Telephone { get; private set; }

        public string Email { get; private set; }

        public string WWW { get; private set; }

        public string CustomerType { get; private set; }
    }
}
