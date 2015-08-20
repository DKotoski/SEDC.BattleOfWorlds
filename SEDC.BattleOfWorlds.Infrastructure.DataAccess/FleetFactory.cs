using SEDC.BattleOfWorlds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public static class FleetFactory
    {
        private static BattleDbContext db = new BattleDbContext();

        public static Fleet NewFleet()
        {
            Fleet result = new Fleet();
            result.Location = Location.Base;
            var ships = result.Ships;
            foreach(var ship in db.Ships)
            {
                ships.Add(new Ship_Data() { EntityID = ship.ID, Quantity = 0 });
            }
            return result;
        }
    }
}
