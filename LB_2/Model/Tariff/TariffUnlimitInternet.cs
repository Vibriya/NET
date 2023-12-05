using LB_1;

namespace LB_2.Properties
{
    public class TariffUnlimitInternet : Tariff
    {
        private const bool HideNumber = true;
        public bool CanHideNumber => HideNumber;

        protected TariffUnlimitInternet(
            string name, 
            uint price, 
            int priceMinuteRoaming
            ) : base(name, price, 0, priceMinuteRoaming, int.MaxValue)
        {
        }
        
        public override uint UseVpn(uint mb)
        {
            return VpnPrice * mb;
        }

        public override string ToString()
        {
            return base.ToString() + $"CanHideNumber: {HideNumber} | ";
        }
    }
}