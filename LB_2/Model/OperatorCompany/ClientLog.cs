using System;
using System.Data.Common;

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

    public enum Month
    {
        January = 1, 
        February = 2, 
        March = 3, 
        April = 4, 
        May = 5, 
        June = 6, 
        July = 7, 
        August = 8, 
        September = 9, 
        October = 10, 
        November = 11, 
        December = 12
    }
    
}

