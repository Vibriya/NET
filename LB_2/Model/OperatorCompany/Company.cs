using System;
using System.Collections.Generic;
using LB_1;

namespace LB_2.Model.OperatorCompany
{
    [Serializable]
    public class Company
    {
        private static readonly CompanyValidator Validator = new CompanyValidator();
        
        
        private const int NumbersOfTaxedMonths = 12;
        public string Name { get; set; }
        public Dictionary<int, MobileOperatorAccount> ServicedClientsDict { get; }
        public Dictionary<int, MobileOperatorAccount> NonServicedClientsDict { get; }
        public HashSet<ClientLog> StorageHashSet { get; }
        public string EDRPOY { get; }
        public List<long> IncomeList { get; }
        public long NumberClients { get; protected set; }
        public long CompanyIncomePerMonth { get; protected set; }

        public HashSet<string> LogHashSet = new HashSet<string>();

        private Company(string name, string edrpoy)
        {
            Name = name;
            ServicedClientsDict = new Dictionary<int, MobileOperatorAccount>();
            NonServicedClientsDict = new Dictionary<int, MobileOperatorAccount>();
            StorageHashSet = new HashSet<ClientLog>();
            EDRPOY = edrpoy;
            IncomeList = new List<long>();
            NumberClients = 0;
            CompanyIncomePerMonth = 0;
            
        }

        public static Company Create(string name, string edrpoy) => 
            Validator.ParametersIsValid(name, edrpoy)? 
                new Company(name, edrpoy) : throw new ArgumentException("Company's parameters are invalid");

        public void ConnectNewClient(MobileOperatorAccount mob)
        {
            ServicedClientsDict.Add(mob.Id, mob);
            NumberClients++;
            CompanyIncomePerMonth += mob.Tariff.Price;
        }

        public void StopServiceClient(int mobId)
        {
            var curMob = ServicedClientsDict[mobId];
            NonServicedClientsDict.Add(mobId, curMob);
            ServicedClientsDict.Remove(mobId);
            NumberClients--;
            CompanyIncomePerMonth -= curMob.Tariff.Price;
        }

        public double[] GetTaxList()
        {
            var taxes = new double[NumbersOfTaxedMonths];
            for (var i = 0; i < taxes.Length; i++)
            {
                uint sum = 0;
                foreach (var clientLog in StorageHashSet)
                    if (clientLog.CurMonth == i) sum += clientLog.CompanyIncome;
                
                taxes[i] = (CompanyIncomePerMonth + sum) * 0.15;
            }
            return taxes;
        }

        public override string ToString()
        {
            return $"Company Name: {Name}   EDRPOY: {EDRPOY}   NumberClients: {NumberClients}";
        }

        public void AddOperationToLogs(string log)
        {
            LogHashSet.Add(log);
        }
    }
}