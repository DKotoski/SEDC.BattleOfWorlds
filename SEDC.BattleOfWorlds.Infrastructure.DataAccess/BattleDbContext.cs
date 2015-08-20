using SEDC.BattleOfWorlds.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess
{
    public class BattleDbContext : DbContext
    {
        public BattleDbContext():base("name=SEDCBattleOfWorldsInfrastructureWebUIContext")//TODO: enter the proper name of the db
        {

        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Building_Data> BuildingData { get; set; }
        public DbSet<Tech> Techs { get; set; }
        public DbSet<Ship> Ships { get; set; }

    }
}
