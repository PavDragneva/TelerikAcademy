namespace Mobile
{
    using System;
    public class Battery
    {
        //Fields
        private string modelOfBattery = null;
        private double? hoursIdleBattery = null;
        private double? hoursTalkBattery = null;
        private BatteryType? batteryTypeOfGSM = null;

        //Constructors
        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(string model, double hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }
        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
            : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        //Properties
        public string Model
        {
            get { return this.modelOfBattery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("You forgot to enter the model of the battery.");
                }
                else
                {
                    this.modelOfBattery = value;
                }
            }
        }
        public double? HoursIdle
        {
            get { return this.hoursIdleBattery; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Hours idle of the battery can't be 0 or negative number.");
                }
                else
                {
                    this.hoursIdleBattery = value;
                }
            }
        }
        public double? HoursTalk
        {
            get { return this.hoursTalkBattery; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Hours talk of the battery can't be 0 or negative number..");
                }
                else
                {
                    this.hoursTalkBattery = value;
                }
            }
        }
        public BatteryType? BatteryType
        {
            get { return this.batteryTypeOfGSM; }
            set
            {this.batteryTypeOfGSM = value;}
        }
    }
}