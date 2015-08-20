using System.Collections.Generic;
using System.Linq;

namespace SEDC.BattleOfWorlds.Domain
{
    public enum Location{Base, Far }
    public class Fleet:BaseEntity
    {
        public virtual List<Ship_Data> Ships{ get; set; }
        public double Speed { get
            {
                return 0;//TODO: some logic to get min speed when speed is inputed
            }
        }
        public Location Location { get; set; }
        public void Battle(Fleet fleet2)
        {
            //TODO: Implement the Battle alghoritm
        }

        public Fleet()
        {
            Ships = new List<Ship_Data>();
          
        }
        
    }
}