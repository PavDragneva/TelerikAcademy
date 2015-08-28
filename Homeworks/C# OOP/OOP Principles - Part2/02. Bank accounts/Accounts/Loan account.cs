public class LoanAccount : Account
{
    public LoanAccount(CustumerType custumer, decimal balance, double interestRate)
            : base(custumer, balance, interestRate)
        {

        }

    public override void Deposit(decimal sum)
    {
        this.Balance += sum;
    }
    public override double InterestAmount(int months)
        {
            if (Custumer == CustumerType.Individual)
            {
                if (months > 3)
                {
                    return (months - 3) * this.InterestRate;
                }
                else
                {
                    return 0;
                }
            }
        else
            {
                if (months > 2)
                {
                    return (months - 2) * this.InterestRate;
                }
                else
                {
                    return 0;
                }
            }
        }
}