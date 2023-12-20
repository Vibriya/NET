using System;
using System.Linq;
using LB_2;
using LB_2.Model.OperatorCompany;

namespace LB_1
{
    [Serializable]
    public class MobileOperatorAccount
    {
        private static readonly AccountValidateHelper MobChecker = new AccountValidateHelper();
        private static readonly GeneratorHelper GeneratorHelper = new GeneratorHelper();
        private readonly Company _company;
        
        public int Id { get; }

        public string OperatorName { get; }
        
        public string PhoneNumber { get; }
        
        public long CurrentAccount { get; set; }

        public bool Paid { get; }

        public bool InRoaming { get; }

        public Tariff Tariff { get; set; }

        private Call[] _callHistory;

        //Конструктор для створення дефолтного рахунку
        public MobileOperatorAccount() : this(
            Company.Create("", ""),
            "Kyivstar",
            new TariffTurbo(),
            false,
            false,
            1000,
            GeneratorHelper.NextPhone()){}
        
        //Приватний конструктор з параметрами, використовується в Create()
        private MobileOperatorAccount(
            Company company,
            string operatorName, 
            Tariff tariff, 
            bool paid, 
            bool inRoaming, 
            int currentAccount, 
            string phoneNumber)
        {
            _company = company;
            Id = GeneratorHelper.GenerateAccountId();
            OperatorName = operatorName;
            Tariff = tariff;
            Paid = paid;
            InRoaming = inRoaming;
            CurrentAccount = currentAccount;
            PhoneNumber = phoneNumber;
            _callHistory = Array.Empty<Call>();
        }
        
        /*Метод для перевірки аргументів конструктора.
         Повертає екземпляр рахунку у разі успуху або кидає ArgumentException*/
        public static MobileOperatorAccount Create(
            Company company,
            string name, 
            Tariff tariff, 
            bool paid, 
            bool roaming,
            int currentAccount, 
            string phoneNumber
        )
        {
            return MobChecker.AcceptableData(name, phoneNumber)? 
                new MobileOperatorAccount(
                    company,
                    name, 
                    tariff, 
                    paid, 
                    roaming,
                    currentAccount, 
                    phoneNumber
                ) :
            throw new ArgumentException("MobileOperatorAccount.Create() arguments are not valid");
        }
        
        public OperatorError StartCall(uint minutes, string toNumber, out uint price)
        {
            price = 0;
            if (minutes <= 0) return OperatorError.MINUTES_NEGATIVE_ERROR; 
            if (!MobChecker.AcceptableNumber(toNumber)) return OperatorError.CHECKER_ERROR;
            
            price = Tariff.Call(minutes, Paid, InRoaming);
            CurrentAccount -= price;
            _callHistory = _callHistory.Append(new Call(toNumber, DateTime.Now , minutes)).ToArray();
            if(price != 0) _company.StorageHashSet.Add(new ClientLog(Id, price));
            _company.AddOperationToLogs($"Call from {Id}:{PhoneNumber} to {toNumber} for {minutes} cost {price}");
            return OperatorError.SUCCESS;
        }

        public void ChangeTariff(Tariff newTariff)
        {
            Tariff = newTariff;
            _company.AddOperationToLogs($"{Id} changed tariff from {Tariff.Name} to {newTariff.Name}");
        } 

        public void AddMoney(uint money)
        {
            CurrentAccount += money;
            _company.AddOperationToLogs($"{Id} added {money} money");
        } 

        public uint UseVpn(uint mb)
        {
            var res = Tariff.UseVpn(mb);;
            if(res != 0) _company.StorageHashSet.Add(new ClientLog(Id, res));
            _company.AddOperationToLogs($"{Id} use internet. Cost {res}");
            return res;
        } 

        /*Метод отримання історії дзвінків.
        Повертає копію масиву для дотримання інкапсуляції*/
        public Call[] GetCalls() => (Call[]) _callHistory.Clone();

        public override string ToString()
        {
            return $"OperatorName: {OperatorName} | " + 
                $"Tariff: {Tariff}" + 
                $"Account: {CurrentAccount} | " + 
                $"Paid: {Paid} | " + 
                $"Roaming: {InRoaming} | " + 
                $"Number: {PhoneNumber}";
        }
        
    }
}



