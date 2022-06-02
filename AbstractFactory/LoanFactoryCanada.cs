namespace AbstractFactory
{
    internal class LoanFactoryCanada : LoanFactory
    {
        public override IBalanceCheck CreateBalanceCheck()
        {
            return new BalanceCheckCanda();
        }

        public override ICreditCheck CreateCreditCheck()
        {
            return new CreditCheckCanada();
        }
    }
}