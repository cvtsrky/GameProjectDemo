using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product added");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product deleted");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Product updated");
        }
    }
}
