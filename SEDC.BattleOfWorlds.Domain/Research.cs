using System.Collections.Generic;

namespace SEDC.BattleOfWorlds.Domain
{
    public class Research : BaseEntity
    {
        public virtual List<Research_Data> Techs{ get; set; }
        public Research()
        {
            Techs = new List<Research_Data>();
        }
    }
}