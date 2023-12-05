using System;
using System.Linq;

namespace LB_1
{
    //Валідатор для рахунку мобільного оператора
    public class AccountValidateHelper : Helper
    {
        public bool AcceptableData(string name, string number) =>
            name.Length != 0 && AcceptableNumber(number);
        public bool AcceptableNumber(string number) =>
            number.Length == NumberLenght 
            && number.All(char.IsDigit)
            && Array.Exists(OperatorOpcode, opcode => opcode.Equals(number.Substring(0, 3)));
        
    }
}