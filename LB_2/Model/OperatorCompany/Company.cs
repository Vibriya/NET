using System;
using System.Collections.Generic;
using LB_1;

namespace LB_2.Model.OperatorCompany
{
    public class Company
    {
        public string Name { get; set; }
        public Dictionary<long, MobileOperatorAccount> ClientsDict { get; }
        public HashSet<string> StorageHashSet { get; }
        public string EDRPOY { get; }
        public List<long> IncomeList { get; }
        public long NumberClients { get; }

        private Company(string name, string edrpoy)
        {
            Name = name;
            ClientsDict = new Dictionary<long, MobileOperatorAccount>();
            StorageHashSet = new HashSet<string>();
            EDRPOY = edrpoy;
            IncomeList = new List<long>();
            NumberClients = 0;
        }

        public Company Create(string name, string edrpoy) => 
            CompanyValidator.ParametersIsValid(name, edrpoy)? 
                new Company(name, edrpoy) : throw new ArgumentException("Company's parameters are invalid");
    }
}