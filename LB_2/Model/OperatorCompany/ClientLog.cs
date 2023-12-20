using System;

namespace LB_2.Model.OperatorCompany
{
    [Serializable]
    public struct ClientLog
    {
        public int AccountId { get; }
        public int CurMonth { get; }
        public uint CompanyIncome { get; }
        public string Description { get; }

        public ClientLog(int accountId, string description, uint companyIncome = 0)
        {
            AccountId = accountId;
            CurMonth = DateTime.Now.Month;
            CompanyIncome = companyIncome;
            Description = description;
        }
    }
    
}

