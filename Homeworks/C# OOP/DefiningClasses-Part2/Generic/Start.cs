using System;
class Start
{
    static void Main()
    {
        //Some tests. You can change values to check the correct work of the program.
        GenericList<int> sampleList = new GenericList<int>(5);
        sampleList.AddToGenericList(7);
        sampleList.AddToGenericList(5);
        sampleList.AddToGenericList(1);
        sampleList.AddToGenericList(70);
        sampleList.AddToGenericList(-7);
        string listElements = sampleList.ToString();
        Console.WriteLine("Sample list: {0}", listElements);
        int element = sampleList.AcessByIndex(1);
        Console.WriteLine("The value of the element on index 1 is {0}", element);
        sampleList.RemoveByIndex(1);
        Console.WriteLine("Sample list: {0}", sampleList);
        sampleList.InsertAtPosition(2, 222);
        Console.WriteLine("Sample list: {0}", sampleList);
        int index = sampleList.FindByValue(70);
        Console.WriteLine("1 is on index {0}", index);
        int min = sampleList.Min();
        int max = sampleList.Max();
        Console.WriteLine("Min value - {0} \nMax value - {1}", min, max);
        sampleList.ClearingList();
        Console.WriteLine("Sample list: {0}", sampleList);
    }
}