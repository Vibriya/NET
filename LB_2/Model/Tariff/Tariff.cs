
namespace LB_1
{

    public abstract class Tariff
    {
        public string Name { get; }

        public uint Price { get; }

        public int PriceMinute { get; }

        public int PriceMinuteRoaming { get; }

        public uint Internet { get; set; }

        protected const uint VpnPrice = 2;
        

        protected Tariff(string name, uint price, int priceMinute, int priceMinuteRoaming, uint internet)
        {
            Name = name;
            Price = price;
            PriceMinute = priceMinute;
            PriceMinuteRoaming = priceMinuteRoaming;
            Internet = internet;
        }

        public int Call(int minutes, bool paid, bool inRoaming) => 
            minutes * (paid ? 0 : inRoaming ? PriceMinuteRoaming : PriceMinute);
        

        public virtual uint UseVpn(uint mb)
        {
            if (mb > Internet) return 0;
            Internet -= mb;
            return VpnPrice * mb;
        }

        public override string ToString()
        {
            return $"Name: {Name} | " +
                   $"Price: {Price} | " +
                   $"PriceMinute : {PriceMinute} | " +
                   $"PriceMinuteRoaming : {PriceMinuteRoaming} | " +
                   $"Internet : {(Internet == int.MaxValue ? "Unlimit" : Internet.ToString())} | ";
        }
        
    }
}