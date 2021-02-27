using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.Concrete;
using GameProjectDemo.Adapters;
using System;

namespace GameProjectDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Doğru bilgiler girilmeden hata verir
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer
            {
                DateOfBirth = new DateTime(1995, 5, 11),
                FirstName = "Cevat",
                LastName = "Sarıkaya",
                NationalityId = "12536"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                Id = 2,
                Name = "1 al 2 öde",
                Discount = 10
            });

            ProductManager productManager = new ProductManager();
            productManager.Add(new Product
            {
                Id = 3,
                Name = "Mario",
                Price = 15
            });

            SalesManager salesManager = new SalesManager();
            salesManager.Add(new Gamer {FirstName="Cevat" }, new Product { Name = "Mario" }, new Campaign { Name = "1 al 2 öde" });

            
        }
    }
}
