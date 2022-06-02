namespace AbstractFactory
{
    interface ICreditCheck
    {
        int GetCreditScore(string firstName, string lastName, int PersonID);
    }
}