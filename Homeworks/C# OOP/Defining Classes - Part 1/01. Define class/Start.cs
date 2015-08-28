namespace Mobile
{
    using System;
    class Start
    {
        static void Main()
        {
            GSMTest test = new GSMTest();
            test.ReadGSM();
            Console.WriteLine(GSM.IPhone4S);
            GSMCallHistoryTest.myGSM.AddCalls(new DateTime(2015, 03, 12, 13, 23, 56), "0899999999", 167);
            GSMCallHistoryTest.myGSM.AddCalls(new DateTime(2015, 03, 11, 10, 09, 00), "0878888888", 390);
            GSMCallHistoryTest.myGSM.AddCalls(new DateTime(2015, 03, 10, 15, 23, 56), "0899997969", 300);
            GSMCallHistoryTest.myGSM.AddCalls(new DateTime(2015, 02, 11, 10, 09, 00), "0878980818", 55);
            Console.WriteLine();
            GSMCallHistoryTest.myGSM.PrintHistory();
            GSMCallHistoryTest.myGSM.TotalPrice();
            GSMCallHistoryTest.myGSM.RemoveLongestCall();
            Console.WriteLine();
            Console.WriteLine("After removing longest call");
            Console.WriteLine(new string('*', Console.WindowWidth));
            GSMCallHistoryTest.myGSM.TotalPrice();
        }
    }
}