namespace AbstractFactory
{
    abstract class LoanFactory // abstract factory
    {
        public abstract ICreditCheck CreateCreditCheck();

        public abstract IBalanceCheck CreateBalanceCheck();
    }
}