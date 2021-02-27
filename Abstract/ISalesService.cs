using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISalesService
    {
        void Add(Gamer gamer, Product product, Campaign campaign);
        void Update(Gamer gamer, Product product, Campaign campaign);
        void Delete(Gamer gamer, Product product, Campaign campaign);
    }
}
