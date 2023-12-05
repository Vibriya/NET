using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LB_1
{
    //Клас для випадкової генерації допоміжної інформації
    public class GeneratorHelper : Helper
    {
        private static readonly Random _random = new Random();
        private static readonly HashSet<long> PreviousIds = new HashSet<long>();
        
        //Генерація номеру телефону з урахуванням коду оператора
        public string NextPhone()
        {
            var numberBuilder = new StringBuilder(OperatorOpcode[_random.Next(0, OperatorOpcode.Length)]);
            for (int i = 0; i < NumberLenght - OperatorOpcode.Length; i++)
            {
                numberBuilder.Append(_random.Next(0, 9));
            } 
            return numberBuilder.ToString();
        }

        public int GenerateAccountId()
        {
            while (true)
            {
                var potentialId = _random.Next();
                if (!PreviousIds.Contains(potentialId))
                {
                    return potentialId;
                }
            }
            
        }
    }
}