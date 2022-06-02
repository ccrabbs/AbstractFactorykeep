using System.Collections.Generic;

namespace AbstractFactory
{
    class BalanceCheckUS : IBalanceCheck
    {
        public double GetCurrentBalance(List<BankInfo> BList)
        {
            double bal = 0;
            foreach (BankInfo bi in BList)
            {
                if (string.Equals(bi.BankName, "CITY BANK", System.StringComparison.CurrentCultureIgnoreCase)
                    && (bi.CheckingAccountNum == 12345))
                {
                    bal = 1275;
                }

                if (string.Equals(bi.BankName, "CITY BANK", System.StringComparison.CurrentCultureIgnoreCase) && (bi.CheckingAccountNum == 123456))
                {
                    bal = 4500;
                }

                break;
            }
            return bal;
        }

        public double GetOutstandingLoans(List<BankInfo> BList)
        {
            double loanAmt = 0;
            foreach (BankInfo bi in BList)
            {
                if (string.Equals(bi.BankName, "CITY BANK", System.StringComparison.CurrentCultureIgnoreCase)
                    && (bi.LoanAccountNum == 12345))
                {
                    loanAmt = 1000;
                }

                if ((string.Equals(bi.BankName, "CITY BANK", System.StringComparison.CurrentCultureIgnoreCase))
                    && (bi.LoanAccountNum == 123456))
                {
                    loanAmt = 8000;
                }

                break;
            }
            return loanAmt;
        }
    }
}