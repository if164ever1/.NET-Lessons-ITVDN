using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2_Controllers.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        static int Number = 1;
        public Product()
        {
            var rand = new Random();
            Id = Number++;
            Name = "product " + Id.ToString();
            Price = rand.NextDouble() * 100;
        }

    }
}
