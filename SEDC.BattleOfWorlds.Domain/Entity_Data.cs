using SEDC.BattleOfWorlds.Domain.Interfaces;

namespace SEDC.BattleOfWorlds.Domain
{
    public abstract class Entity_Data<T> : BaseEntity
    {
        //public T Entity { get; set; }
        public int EntityID { get; set; }
        public int Quantity { get; set; }
        public Entity_Data()
        {
            Quantity = 0;
        }
    }
}