using System;
using System.Collections.Generic;
using System.IO;

using Lesson1.Models;

namespace Lesson1
{
    public class ProducrReader
    {
        private const string path = "App_Data/data.txt";

        public List<Product> ReadFromFile()
        {
            string[] lines = File.ReadAllLines(path);
            List<Product> result = new List<Product>();

            foreach (var item in lines)
            {
                string[] items = item.Split(',');

                Product product = new Product();
                product.Id = Convert.ToInt32(items[0].Trim());
                product.name = items[1].Trim();
                product.Description = items[2].Trim();
                product.Price = Convert.ToDouble(items[3].Trim());
                product.StorageCount = Convert.ToInt32(items[4].Trim());
                product.Category = items[5].Trim();

                result.Add(product);
            }
            return result;
        }
    }
}
