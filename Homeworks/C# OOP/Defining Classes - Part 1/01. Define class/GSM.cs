namespace Mobile
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        //Fields
        private static GSM iPhone4S = new GSM("4S", "IPhone", 699.50m, "Unknown",
                                                 new Battery("ExtraLife", 12.3, 3.5, BatteryType.NiCd),
                                                 new Display(5.5, 3000000));
        private string modelOfGSM;
        private string manufacturerOfGSM;
        private decimal? priceGSM = null;
        private string ownerOfGSM = null;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory;
        private const decimal pricePerMinute = 0.37m;

        //Constructors
        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Calls>();
        }
        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
            : this(model, manufacturer, battery, display)
        {
            this.Price = price;
            this.CallHistory = new List<Calls>();
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, battery, display)
        {
            this.Owner = owner;
            this.CallHistory = new List<Calls>();
        }

        //Properties
        public string Model
        {
            get { return this.modelOfGSM; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You forgot to select the model of the GSM.");
                }
                else
                {
                    this.modelOfGSM = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturerOfGSM; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You forgot to select the manufacturer of the GSM.");
                }
                else
                {
                    this.manufacturerOfGSM = value;
                }
            }
        }
        public decimal? Price
        {
            get { return this.priceGSM; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("There's no free lunch.");
                }
                else
                {
                    this.priceGSM = value;
                }
            }
        }
        public string Owner
        {
            get { return this.ownerOfGSM; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You forgot to select the owner of the GSM.");
                }
                else
                {
                    this.ownerOfGSM = value;
                }
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public List<Calls> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        //Methods
        public override string ToString()
        {
            string info = "The model of the GSM is " + this.Model
                + " by " + this.Manufacturer + " and his price is "
                + this.Price + ". The name of the owner is " + this.Owner + ". The model of the battery is "
                + this.battery.Model + ", hours idle are - " + this.battery.HoursIdle + " and hours talk are " + this.battery.HoursTalk;
            return info;
        }
        public void ClearHistory()
        {
            this.callHistory.Clear();
        }
        public void AddCalls(DateTime dateAndTime, string number, int duration)
        {
            callHistory.Add(new Calls(dateAndTime, number, duration));
        }
        public void DeleteCalls(int duration)
        {
            foreach (Calls call in callHistory)
            {
                if (call.DurationSeconds == duration)
                {
                    callHistory.Remove(call);
                    break;
                }
            }
        }
        public void PrintHistory()
        {
            Console.WriteLine("Calls History");
            Console.WriteLine(new string('*', Console.WindowWidth));
            foreach (Calls call in callHistory)
            {
                Console.WriteLine(call.DateAndTime);
                Console.WriteLine(call.NumberDialed + " - " + call.DurationSeconds + " seconds");
                Console.WriteLine();
            }
        }
        public void TotalPrice()
        {
            decimal totalCost = 0;
            foreach (Calls call in callHistory)
            {
                if (call.DurationSeconds % 60 == 0)
                {
                    totalCost += (call.DurationSeconds / 60) * pricePerMinute;
                }
                else
                {
                    totalCost += ((call.DurationSeconds / 60) + 1) * pricePerMinute;
                }
            }
            Console.WriteLine("Total cost: " + totalCost);
        }
        public void RemoveLongestCall()
        {
            int maxDuration = 0;
            foreach (Calls call in callHistory)
            {
                if (call.DurationSeconds > maxDuration)
                {
                    maxDuration = call.DurationSeconds;
                }
            }
            DeleteCalls(maxDuration);
        }
    }
}