using System;
using System.Collections.Generic;
using LB_1;

namespace LB_2.Model.OperatorCompany
{
    [Serializable]
    public class Company
    {
        private static readonly CompanyValidator Validator = new CompanyValidator();
        private event Action<int> ClientRegistrationHandler;
        
        private const int NumbersOfTaxedMonths = 12;
        public string Name { get; set; }
        public Dictionary<int, MobileOperatorAccount> ServicedClientsDict { get; }
        public Dictionary<int, MobileOperatorAccount> NonServicedClientsDict { get; }
        public HashSet<ClientLog> StorageHashSet { get; }
        public string EDRPOY { get; }
        public List<long> IncomeList { get; }
        public long NumberClients { get; protected set; }
        public long CompanyIncomePerMonth { get; protected set; }

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
            ClientRegistrationHandler = id => Console.WriteLine($"Client {id} was added");
        }

        public static Company Create(string name, string edrpoy) => 
            Validator.ParametersIsValid(name, edrpoy)? 
                new Company(name, edrpoy) : throw new ArgumentException("Company's parameters are invalid");

        public void ConnectNewClient(MobileOperatorAccount mob)
        {
            ServicedClientsDict.Add(mob.Id, mob);
            NumberClients++;
            CompanyIncomePerMonth += mob.Tariff.Price;
            
            mob.ClientEventHandler += log => StorageHashSet.Add(log);
            mob.ChangedTariffHandler += (id, from, to) =>
            {
                StorageHashSet.Add(new ClientLog(
                    id,
                    $"{id} changed tariff from {from.Name} to {to.Name}"
                ));
                CompanyIncomePerMonth -= from.Price - to.Price;
            };
            ClientRegistrationHandler?.Invoke(mob.Id);
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
                    if (clientLog.CurMonth == i && clientLog.CompanyIncome != 0) 
                        sum += clientLog.CompanyIncome;
                
                taxes[i] = (CompanyIncomePerMonth + sum) * 0.15;
            }
            return taxes;
        }

        public void CallWasHappened()
        {
            /*StorageHashSet.Add(new ClientLog(
                Id,
                $"Call from {Id} with phone {PhoneNumber} to {toNumber} for {minutes} min cost {price}",
                price
            );*/
        }

        public override string ToString()
        {
            return $"Company Name: {Name}   EDRPOY: {EDRPOY}   NumberClients: {NumberClients}";
        }
    }
}