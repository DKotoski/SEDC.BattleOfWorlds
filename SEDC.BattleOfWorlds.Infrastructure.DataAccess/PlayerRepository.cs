using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public class PlayerRepository : IBaseRepository<Player>
    {
        private BattleDbContext db = new BattleDbContext();
        public void Add(Player entity)
        {
            db.Players.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Player entity)
        {
            db.Players.Remove(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Players.Remove(db.Players.Find(id));
            db.SaveChanges();
        }

        public Player Get(int id)
        {
            return db.Players.Find(id);
        }

        public Player GetCurrent()
        {
            var currUser = System.Web.HttpContext.Current.User.Identity.Name;//TODO: Make this dynamic
            var res = db.Users
                .FirstOrDefault(x => x.Username == currUser).Player;
            return res;
        }
    }
}
