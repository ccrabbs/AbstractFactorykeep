using System.Collections.Generic;

namespace AbstractFactory
{
    internal class BalanceCheckCanda : IBalanceCheck
    {
        public double GetCurrentBalance(List<BankInfo> BList)
        {
            double bal = 0;
            foreach (BankInfo bi in BList)
            {
                if (bi.BankName.Equals("BANK OF CANADA", System.StringComparison.CurrentCultureIgnoreCase)
                    && (bi.CheckingAccountNum == 123459))
                {
                    bal = 2275;
                }

                if (string.Equals(bi.BankName, "BANK OF CANADA", System.StringComparison.CurrentCultureIgnoreCase)
                    && (bi.CheckingAccountNum == 1234569))
                {
                    bal = 3500;
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
                if (string.Equals(bi.BankName, "BANK OF CANADA", System.StringComparison.CurrentCultureIgnoreCase)
                    && (bi.LoanAccountNum == 123459))
                {
                    loanAmt = 100;
                }

                if ((string.Equals(bi.BankName, "BANK OF CANADA", System.StringComparison.CurrentCultureIgnoreCase))
                    && (bi.LoanAccountNum == 1234569))
                {
                    loanAmt = 5000;
                }

                break;
            }
            return loanAmt;
        }
    }
}