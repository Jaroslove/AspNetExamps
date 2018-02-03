using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models.ForView
{
    public class Products
    {
        public static List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(new Product(i, $"name {i}"));
            }

            return list;
        }
    }
}