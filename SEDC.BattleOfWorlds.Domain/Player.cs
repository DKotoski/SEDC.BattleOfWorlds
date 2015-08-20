using System.Collections.Generic;

namespace SEDC.BattleOfWorlds.Domain
{
    public class Player : BaseEntity
    {
        public virtual Base Base { get; set; }
        public virtual List<Fleet> Fleets { get; set; }
        public virtual Research Research { get; set; }
        public Player()
        {
            Base = new Base();
            Fleets = new List<Fleet>();
            Research = new Research();
            Fleets.Add(new Fleet()
            {
                Ships = new List<Ship_Data>()
                {
                    new Ship_Data()
                }
            });

        }
    }
}