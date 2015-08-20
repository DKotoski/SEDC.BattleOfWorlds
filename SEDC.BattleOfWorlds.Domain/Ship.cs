namespace SEDC.BattleOfWorlds.Domain
{
    public enum ShipType
    {
        normal, bomber, flagship
    }
    public class Ship:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }
        public double Speed { get; set; }
        public int CargoMax { get; set; }
        public int CargoCurr { get; set; }
        public int Price { get; set; }
        public int BuildTime { get; set; }
        public ShipType ShipType { get; set; }
    }
}