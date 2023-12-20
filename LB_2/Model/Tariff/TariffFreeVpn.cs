using System;
using LB_2.Properties;

namespace LB_2
{
    [Serializable]
    public class TariffFreeVpn : TariffUnlimitInternet
    {
        private const bool FreeVpn = true;
        public bool HaveFreeVpn => FreeVpn;

        protected TariffFreeVpn(
            string name, 
            uint price, 
            uint priceMinuteRoaming
            ) : base(name, price, priceMinuteRoaming)
        {
        }
        
        public override uint UseVpn(uint mb) => 0;
        
        public override string ToString() => base.ToString() + $"FreeVpn: {FreeVpn} | ";
    }
}