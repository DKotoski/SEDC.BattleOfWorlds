using System.Collections.Generic;

namespace SEDC.BattleOfWorlds.Domain
{
    public class Base : BaseEntity
    {
        public virtual List<Building_Data> Buildings { get; set; }
        public Base()
        {
            Buildings = new List<Building_Data>();
        }
    }
}