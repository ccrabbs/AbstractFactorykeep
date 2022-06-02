using System;

namespace AbstractFactory
{
    class CreditCheckCanada : ICreditCheck
    {
        public int GetCreditScore(string firstName, String lastName, int PersonID)
        {
            int creditScore = 0;
            if ((firstName == "Matt") && (lastName == "Baker") && (PersonID == 1112233339))
                creditScore = 59;
            if ((firstName == "Polly") && (lastName == "Simsom") && (PersonID == 1112244449))
                creditScore = 69;
            return creditScore;
        }
    }
}