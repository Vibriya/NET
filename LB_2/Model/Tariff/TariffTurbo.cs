using System;
using LB_1;

namespace LB_2
{
    [Serializable]
    public class TariffTurbo : TariffFreeVpn
    {
        public TariffTurbo() : base("Turbo", 200, 8) {}
    }
}