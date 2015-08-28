public class DepositAccount:Account, IWithDrawable
    {
    public DepositAccount(CustumerType custumer, decimal balance, double interestRate)
            : base(custumer, balance, interestRate)
        {

        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override double InterestAmount(int months)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return 0;
            }
            else
            {
                return months * this.InterestRate;
            }
        }

        public void WithDraw(decimal sum)
        {
            this.Balance -= sum;
        }
    }