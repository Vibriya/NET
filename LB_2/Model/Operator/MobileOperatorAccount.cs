using System;
using System.Linq;
using System.Windows.Forms;
using LB_2;
using LB_2.Model.OperatorCompany;

namespace LB_1
{
    [Serializable]
    public class MobileOperatorAccount
    {
        private static readonly AccountValidateHelper MobChecker = new AccountValidateHelper();
        private static readonly GeneratorHelper GeneratorHelper = new GeneratorHelper();
        public event Action<ClientLog> ClientEventHandler;
        public event Action<int, Tariff, Tariff> ChangedTariffHandler;
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
            Id = GeneratorHelper.GenerateAccountId();
            OperatorName = operatorName;
            Tariff = tariff;
            Paid = paid;
            InRoaming = inRoaming;
            CurrentAccount = currentAccount;
            PhoneNumber = phoneNumber;
            _callHistory = Array.Empty<Call>();
            
            ClientEventHandler = log => Console.WriteLine(log.Description);
            ChangedTariffHandler = (id, from, to) =>
                Console.WriteLine($"{id} changed tariff from {from.Name} to {to.Name}"); 
        }
        
        public static MobileOperatorAccount Create(
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
            ClientEventHandler?.Invoke(new ClientLog(
                    Id,  
                    $"Call from {Id} with phone {PhoneNumber} to {toNumber} for {minutes} min cost {price}",
                    price
                )
            );
            return OperatorError.SUCCESS;
        }

        public void ChangeTariff(Tariff newTariff)
        {
            ChangedTariffHandler?.Invoke(Id, Tariff, newTariff);
            Tariff = newTariff;
        } 

        public void AddMoney(uint money)
        {
            CurrentAccount += money;
            ClientEventHandler?.Invoke(new ClientLog(
                    Id, 
                    $"{Id} added {money} money"
                )
            );
        } 

        public uint UseVpn(uint mb)
        {
            var res = Tariff.UseVpn(mb);
            ClientEventHandler?.Invoke(new ClientLog(
                Id, 
                $"{Id} use internet. Cost {res}", 
                res
                )
            );
            return res;
        } 

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



