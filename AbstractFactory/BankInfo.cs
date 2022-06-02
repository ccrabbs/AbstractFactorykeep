using System;

namespace AbstractFactory
{
    internal class BankInfo
    {
        public String BankName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CheckingAccountNum { get; set; }
        public int SavingsAccountNum { get; set; }
        public int LoanAccountNum { get; set; }
    }
}