using System.Collections.Generic;
using LB_1;

namespace LB_2.Model.OperatorCompany
{
    public class Log
    {
        readonly MobileOperatorAccount key;
        readonly List<string> personalLogs;

        public Log(MobileOperatorAccount key)
        {
            this.key = key;
            personalLogs = new List<string>();
        }
    }
}