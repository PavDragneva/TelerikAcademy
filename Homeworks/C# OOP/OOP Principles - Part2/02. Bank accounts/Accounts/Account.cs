public abstract class Account : IDepositable
{
    private CustumerType custumer;
    private decimal balance;
    private double interestRate;

    public Account(CustumerType custumer, decimal balance, double interestRate)
    {
        this.Custumer = custumer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public CustumerType Custumer { get; private set; }
    public decimal Balance { get; internal set; }
    public double InterestRate { get; private set; }

    public abstract double InterestAmount(int months);
    public abstract void Deposit(decimal sum);
}