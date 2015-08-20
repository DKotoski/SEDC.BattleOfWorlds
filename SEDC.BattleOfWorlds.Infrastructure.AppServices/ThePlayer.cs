using SEDC.BattleOfWorlds.Domain;
using SEDC.BattleOfWorlds.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Infrastructure.AppServices
{
    public class ThePlayer
    {
        private Player You = (new PlayerRepository()).GetCurrent();

        public Base Base
        {
            get
            {
                return You.Base;
            }
        }

        public List<Fleet> Fleets
        {
            get
            {
                return You.Fleets;
            }
        }

        public Research Research
        {
            get
            {
                return You.Research;
            }
        }
    }
}
