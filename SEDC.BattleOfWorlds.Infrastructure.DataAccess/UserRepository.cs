using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public class UserRepository : IBaseRepository<User>
    {
        private BattleDbContext db = new BattleDbContext();

        public void Add(User entity)
        {
            if (db.Users.Select(x => x.Username).Contains(entity.Username))
            {
                return;
            }
            else
            {
                entity.Player = PlayerFactory.NewPlayer();
                db.Users.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            db.Users.Remove(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Users.Remove(db.Users.Find(id));
            db.SaveChanges();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Authenticate(string username, string password)
        {
            return db.Users.Any(x => x.Username == username && x.Password == password);
        }
    }
}
