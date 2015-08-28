public class MortageAccount : Account
    {
        public MortageAccount(CustumerType custumer, decimal balance, double interestRate)
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
                if (months < 6)
                {
                    return 0;
                }
                else
                {
                    return (months-6) * this.InterestRate;
                }
            }
            else
            {
                if(months < 12)
                {
                    return (months * this.InterestRate) / 2;
                }
                else
                {
                    return ((months - 12) * this.InterestRate) + ((12*InterestRate) / 2);
                }
            }
        }
    }