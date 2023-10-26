using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Entities
{
    public class Product
    {
        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
