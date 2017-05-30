using System;

namespace Cient_App_for_Warehouse.Repositories
{
    public interface IProductRepository
    {
        int GetPrice(Guid ID);
        int GetIDFromDatabse(Guid ID);
        string GetUnitOfMeasurement(Guid ID);
        int GetAmount(Guid ID);
        string GetProductName(string productName);
    }

   

    public interface IInvoiceRepository
    {
        int GetMaxInvoiceID();


    }

    public interface ISaleRepository
    {
        int GetMaxSaleID();
    }

    public interface ICustomerRepository
    {
        int GetDiscount(Guid ID);
        int GetNIP(Guid ID);
    }

    public interface IEmloyeeRepository
    {
        int GetEmployeeID(string employeeLogin);
    }


}
