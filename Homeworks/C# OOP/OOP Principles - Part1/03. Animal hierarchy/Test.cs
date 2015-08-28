//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
//Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
using System;
class Test
{
    static void Main()
    {
        Animals[] someNoise = new Animals[]
        {
            new Dog(12, "Sharo", Sex.male),
            new Cat(5, "Tomi", Sex.male),
            new Frog(1, "Krqkla", Sex.female),
            new Kitten(0.6, "Siva", Sex.female),
            new Tomcat(0.2, "Drebko", Sex.male)
        };
        foreach(Animals animal in someNoise)
        {
            Console.Write("{0} says: ", animal.Name);
            animal.MakeSomeNoise();
        }

        Dog[] dogs = new Dog[]
        {
            new Dog(3, "Lasi", Sex.female),
            new Dog(1, "Sharo", Sex.male),
            new Dog(8, "Topcho", Sex.male),
            new Dog(4, "Djina", Sex.female)
        };
        double avg = Animals.AverageAge(dogs);
        Console.WriteLine("The average age of the dogs is {0:0.00}", avg);

        Cat[] cats = new Cat[]
        {
            new Cat(7, "Bella", Sex.female),
            new Cat(1, "Puhcho", Sex.male),
            new Cat(2, "Rijko", Sex.male),
            new Cat(3, "Siva", Sex.female)
        };
        avg = Animals.AverageAge(cats);
        Console.WriteLine("The average age of the cats is {0:0.00}", avg);

        Frog[] frogs = new Frog[]
        {
            new Frog(1.5, "Krastavelka", Sex.female),
            new Frog(2, "Zelenushko", Sex.male),
            new Frog(4.3, "Skoklio", Sex.male),
            new Frog(1, "Krqkla", Sex.female)
        };
        avg = Animals.AverageAge(frogs);
        Console.WriteLine("The average age of the frogs is {0:0.00}", avg);

        Kitten[] kittens = new Kitten[]
        {
            new Kitten(0.5, "Puhi", Sex.female),
            new Kitten(0.7, "Tigyrka", Sex.female),
            new Kitten(0.9, "Rijka", Sex.female),
            new Kitten(0.2, "Mynichka", Sex.female)
        };
        avg = Animals.AverageAge(kittens);
        Console.WriteLine("The average age of the kittens is {0:0.00}", avg);

        Tomcat[] tomcats = new Tomcat[]
        {
            new Tomcat(0.3, "Puhcho", Sex.male),
            new Tomcat(0.2, "Tigyr", Sex.male),
            new Tomcat(0.9, "Rijko", Sex.male),
            new Tomcat(1, "Chernyo", Sex.male)
        };
        avg = Animals.AverageAge(tomcats);
        Console.WriteLine("The average age of the tomcats is {0:0.00}", avg); 
    }
}