using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager:BaseGamerManager
    {
        IGamerCheckService gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService;
        }
        public override void Add(Gamer gamer)
        {
            if (gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
