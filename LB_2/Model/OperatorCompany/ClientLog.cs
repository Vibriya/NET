using System;

namespace LB_2.Model.OperatorCompany
{
    public class ClientLog
    {
        public int AccountId { get; protected set; }
        public int CurMonth { get; protected set; }
        public uint CompanyIncome { get; set; }

        public ClientLog(int accountId, uint companyIncome)
        {
            AccountId = accountId;
            CurMonth = DateTime.Now.Month;
            CompanyIncome = companyIncome;
        }
    }
    
}

