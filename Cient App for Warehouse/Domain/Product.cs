using Cient_App_for_Warehouse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    public interface IProduct
    {
        Guid ID { get; }
        string Name { get; }
        int Amount { get; }
        int Price { get; }
        Brewery Brewery { get; }
        string Distributor { get; }
        string BeerType { get; }
        string UnitOfMeasurement { get; }
        int BarCode { get; }

        int SetAmount(int amount);
        void SetName(string name);
        string ToString(Product product);
    }

    public class Product : IProduct
    {
        public virtual Guid ID { get; private set; }
        public virtual string Name { get; private set; }
        public virtual int Amount { get; private set; }
        public virtual int Price { get; private set; }
        public virtual string Distributor { get; private set; }
        public virtual string BeerType { get; private set; }
        public virtual string UnitOfMeasurement { get; private set; }
        public virtual int BarCode { get; private set; }

        public Brewery Brewery { get; private set; }

        public Product(int amount, string name)
        {
            ID = Guid.NewGuid();
            SetAmount(amount);
            SetName(name);
        }

        public int SetAmount(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be greater than 0. ");
            }

            Amount += amount;
            return Amount;
        }
        public void SetName(string name)
        {
            if(String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty!");
            }
            if(Name == name)
            {
                return;
            }

            Name = name;
        }

        public string ToString(Product product)
        {

            string toString = $"Name: {Name}, Amount: {Amount}, Price: {Price}";
            return toString;
        }
    }
}
