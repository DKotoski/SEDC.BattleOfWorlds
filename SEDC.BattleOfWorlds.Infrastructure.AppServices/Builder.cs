using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.AppServices
{
    public static class Builder
    {
        private static BattleDbContext db = new BattleDbContext();
        public static void Building(int BuildingDataID)
        {
            db.BuildingData.Single(x=>x.ID==BuildingDataID).Quantity+=1;
        }
    }
}
