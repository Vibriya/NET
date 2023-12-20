using System.Collections.Generic;

namespace LB_2.Model.OperatorCompany
{
    public class CompanyInfo
    {
        public string Name { get; set; }
        public string EDRPOY { get; }
        public List<long> IncomeList { get; }
        public long NumberClients { get; protected set; }
    }
}