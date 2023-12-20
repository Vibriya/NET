using System;
using LB_1;
using LB_2.Properties;

namespace LB_2
{
    [Serializable]
    public class TariffPro : TariffUnlimitInternet
    {
        public TariffPro() : base("Pro", 150, 8) {}
    }
}