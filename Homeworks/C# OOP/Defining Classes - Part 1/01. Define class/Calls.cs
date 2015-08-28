namespace Mobile
{
    using System;
    public class Calls
    {
        //Fields
        private DateTime dateAndTime;
        private string numbersDialed;
        private int durationSeconds;

        //Constructors
        public Calls(DateTime dateAndTime, string numbersDialed, int durationSeconds)
        {
            this.DateAndTime = dateAndTime;
            this.NumberDialed = numbersDialed;
            this.DurationSeconds = durationSeconds;
        }

        //Properties
        public DateTime DateAndTime
        { get; set; }
        public string NumberDialed
        { get; set; }
        public int DurationSeconds
        { get; set; }
    }
}

