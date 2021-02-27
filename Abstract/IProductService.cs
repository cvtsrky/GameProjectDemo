using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IProductService
    {        
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
