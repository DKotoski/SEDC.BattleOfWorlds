namespace SEDC.BattleOfWorlds.Domain
{
    public class Tech:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public int BuildTime { get; set; }
    }
}