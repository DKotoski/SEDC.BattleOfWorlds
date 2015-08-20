using SEDC.BattleOfWorlds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public static class PlayerFactory
    {
        private static BattleDbContext db = new BattleDbContext();
        public static Player NewPlayer()
        {
            Player result = new Player();
            var buildings = result.Base.Buildings;
            foreach (var building in db.Buildings)
            {
                buildings.Add(new Building_Data() { EntityID = building.ID, Quantity = 0 });
                db.Buildings.Remove(building);
            }

            result.Fleets.Add(FleetFactory.NewFleet());

            var research = result.Research.Techs;
            foreach (var tech in db.Techs)
            {
                research.Add(new Research_Data() { EntityID = tech.ID, Quantity = 0 });
            }
            return result;
        }
    }
}
