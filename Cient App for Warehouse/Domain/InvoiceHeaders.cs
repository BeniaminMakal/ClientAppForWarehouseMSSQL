using System;

namespace Cient_App_for_Warehouse
{
    public interface IInvoiceHeaders
    {
        int InvoiceID { get; }
        string PartnerID { get; }
        string Payment { get; }
        int Discount { get; }
        DateTime TransactionTime { get; }
        decimal InvoiceValue { get; }
    }

    public class InvoiceHeaders : IInvoiceHeaders
    {
        public int InvoiceID { get; set; }

        public string PartnerID { get; set; }

        public string Payment { get; set; }

        public int Discount { get; set; }

        public DateTime TransactionTime { get; set; }

        public decimal InvoiceValue { get; set; }
    }
}
