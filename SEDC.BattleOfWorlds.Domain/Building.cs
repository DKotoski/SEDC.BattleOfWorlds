namespace SEDC.BattleOfWorlds.Domain
{
    public class Building:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int BuildTime { get; set; }
    }
}