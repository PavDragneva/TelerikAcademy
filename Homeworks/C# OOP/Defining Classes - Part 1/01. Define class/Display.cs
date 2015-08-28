namespace Mobile
{
    using System;
    public class Display
    {
        //Fields
        private double sizeDisplay;
        private int colorsOfGSM;

        //Constructors
        public Display(double size)
        {
            this.Size = size;
        }
        public Display(double size, int colors)
            : this(size)
        {
            this.Colors = colors;
        }

        //Properties
        public double Size
        {
            get { return this.sizeDisplay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The size of the display can't be 0 or negative number.");
                }
                else
                {
                    this.sizeDisplay = value;
                }
            }
        }
        public int Colors
        {
            get { return this.colorsOfGSM; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The number of colors can't be 0 or negative number");
                }
                else
                {
                    this.colorsOfGSM = value;
                }
            }
        }
    }
}