using System.Collections.Generic;

namespace AbstractFactory
{
    interface IBalanceCheck
    {
        double GetCurrentBalance(List<BankInfo> BList);

        double GetOutstandingLoans(List<BankInfo> BList);
    }
}