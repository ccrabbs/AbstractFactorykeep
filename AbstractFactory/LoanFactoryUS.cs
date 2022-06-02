namespace AbstractFactory
{
    class LoanFactoryUS : LoanFactory
    {
        public override IBalanceCheck CreateBalanceCheck()
        {
            return new BalanceCheckUS();
        }

        public override ICreditCheck CreateCreditCheck()
        {
            return new CreditCheckUS();
        }
    }
}