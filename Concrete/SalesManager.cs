using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Product product, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.FirstName + "  Product name: " + product.Name +
                "  Campaign name: " + campaign.Name + " added.");
        }

        public void Delete(Gamer gamer, Product product, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.FirstName, "Product name: "
                + product.Name, "Campaign name: " + campaign.Name + "deleted.");
        }

        public void Update(Gamer gamer, Product product, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.FirstName, "Product name: "
                + product.Name, "Campaign name: " + campaign.Name + "updated.");
        }
    }
}
