using System;
using LB_1;

namespace LB_2
{
    
    [Serializable]
    public class TariffStarter : Tariff
    {
        public TariffStarter() : base("Starter", 50, 5, 8, 5000) {}
    }
}