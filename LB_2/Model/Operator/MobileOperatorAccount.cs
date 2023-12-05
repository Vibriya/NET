using System;
using System.Linq;
using LB_2;

namespace LB_1
{
    public class MobileOperatorAccount
    {
        private static readonly AccountValidateHelper MobChecker = new AccountValidateHelper();
        private static readonly GeneratorHelper GeneratorHelper = new GeneratorHelper();
        
        public long Id { get; set; }

        public string OperatorName { get; }
        
        public string PhoneNumber { get; }
        
        public long CurrentAccount { get; set; }

        public bool Paid { get; }

        public bool InRoaming { get; }

        public Tariff Tariff { get; set; }

        private Call[] _callHistory;

        //Конструктор для створення дефолтного рахунку
        public MobileOperatorAccount() : this(
            "Kyivstar",
            new TariffTurbo(),
            false,
            false,
            1000,
            GeneratorHelper.NextPhone()){}
        
        //Приватний конструктор з параметрами, використовується в Create()
        private MobileOperatorAccount(
            string operatorName, 
            Tariff tariff, 
            bool paid, 
            bool inRoaming, 
            int currentAccount, 
            string phoneNumber)
        {
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
            string name, 
            Tariff tariff, 
            bool paid, 
            bool roaming,
            int currentAccount, 
            string phoneNumber
        )
        {
            if (MobChecker.AcceptableData(name, phoneNumber))
                return new MobileOperatorAccount(
                    name, 
                    tariff, 
                    paid, 
                    roaming,
                    currentAccount, 
                    phoneNumber
                );
            throw new ArgumentException("MobileOperatorAccount.Create() arguments is not valid");
        }
        
        public OperatorError StartCall(int minutes, string toNumber, out int price)
        {
            price = 0;
            if (minutes <= 0) return OperatorError.MINUTES_NEGATIVE_ERROR; 
            if (!MobChecker.AcceptableNumber(toNumber)) return OperatorError.CHECKER_ERROR;
            
            price = Tariff.Call(minutes, Paid, InRoaming);
            CurrentAccount -= price;
            _callHistory = _callHistory.Append(new Call(toNumber, DateTime.Now , (uint) minutes)).ToArray();
            return OperatorError.SUCCESS;
        }
        public void ChangeTariff(Tariff newTariff) => Tariff = newTariff;
        public void AddMoney(uint money) => CurrentAccount += money;
        public uint UseVpn(uint mb) => Tariff.UseVpn(mb);

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



