using System;

namespace DemoRandomKlasse
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random(); //Parameterloze constructor
            Console.WriteLine(rand.Next(1, 11));//Random getal tussen 1 en 10

            Random randomGenerator1 = new Random(123);//123 is seed waarde
            //   Seed:
            //     A number used to calculate a starting value for the pseudo-random number sequence.
            Console.WriteLine(randomGenerator1.Next());
            // 2114319875

            Random randomGenerator2 = new Random(456);
            Console.WriteLine(randomGenerator2.Next(50)); //50 is maxwaarde
            // 47

            Random randomGenerator3 = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine(randomGenerator3.Next(50));
        }
    }
}
