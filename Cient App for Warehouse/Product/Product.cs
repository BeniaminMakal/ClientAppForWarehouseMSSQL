using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    public class Product
    {
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public int Price { get; private set; }
        public string Brewery { get; private set; }
        

        public Product(int amount, string name)
        {
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
