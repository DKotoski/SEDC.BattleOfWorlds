using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public class BuildingsRepository : IBaseRepository<Building>
    {
        private BattleDbContext db = new BattleDbContext();

        public void Add(Building entity)
        {
            db.Buildings.Add(entity);
        }

        public void Delete(Building entity)
        {
            db.Buildings.Remove(entity);
        }
        public void Delete(int id)
        {
            db.Buildings.Remove(Get(id));
        }

        public Building Get(int id)
        {
            return db.Buildings.Find(id);
        }

        public List<Building> GetBuildingsInBase(int baseID)
        {
            List<Building> buildings = new List<Building>();
            var players = new PlayerRepository();
            var currplayer = players.GetCurrent();
            var theBase = currplayer.Base;
            foreach(var data in theBase.Buildings)
            {
                buildings.Add(db.Buildings.Find(data.EntityID));
            }
            return buildings;
        }

        public ICollection<Building> GetAll()
        {
            return db.Buildings.ToList();
        }

    }
}
