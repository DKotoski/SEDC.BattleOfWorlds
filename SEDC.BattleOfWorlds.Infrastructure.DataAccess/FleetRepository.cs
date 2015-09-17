using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public class FleetRepository: IBaseRepository<Fleet>
    {
        private BattleDbContext db = new BattleDbContext();


        public void Add(Fleet entity)
        {
            db.Fleets.Add(entity);
        }

        public Fleet Get(int id)
        {
            return db.Fleets.Find(id);
        }

        public void Delete(int id)
        {
            db.Fleets.Remove(Get(id));
        }

        public void Delete(Fleet entity)
        {
            db.Fleets.Remove(entity);
        }

        public ICollection<Fleet> GetAll()
        {
            return db.Fleets.ToList();
        }
    }
}
