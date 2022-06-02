using System;

namespace AbstractFactory
{
    internal class CreditCheckUS : ICreditCheck
    {
        public int GetCreditScore(string firstName, String lastName, int personID)
        {
            int creditScore = 0;
            if ((firstName == "Bill") && (lastName == "Baker") && (personID == 111223333))
                creditScore = 590;
            else if ((firstName == "Sally") && (lastName == "Simsom") && (personID == 111224444))
                creditScore = 690;
            return creditScore;
        }
    }
}