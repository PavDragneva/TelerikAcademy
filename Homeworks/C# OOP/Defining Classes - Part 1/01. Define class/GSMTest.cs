namespace Mobile
{
    using System;
    public class GSMTest
    {
        public void ReadGSM()
        {
            GSM[] mobile = 
        {
            new GSM("S4", "Samsung", new Battery("Energetic", 12.2, 4.3, BatteryType.NiMH), new Display(4.9)),
            new GSM("T10", "Nokia", 299.50m, "Peter", new Battery("ExtraPower"), new Display(5.5, 20000)),
            new GSM("R20", "Motorolla", 680.20m, new Battery("Long live", 12), new Display(5))
         };
            
            foreach (var phone in mobile)
            {
                Console.WriteLine(phone);
            }
        }
    }
}

