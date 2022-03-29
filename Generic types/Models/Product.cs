using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Models
{
     abstract class Product
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome { get; set; }

        public Product(string name, double price, int count)
        {
            _id++;
            Name = name;
            Price = price;
            Count = count;

        }
        public abstract void Sell();
        public abstract void ShowInfo();

        
    }
}
