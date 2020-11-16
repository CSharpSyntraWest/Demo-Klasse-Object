using System;

namespace Demo_UitgebreideObjectInitializers
{
    public class Rechthoek
    {
        public double Breedte { get; set; } //Auto-property
        public double Hoogte { get; set; } //Auto-property 

    }
    class Program
    {
        static void Main()
        {
            Rechthoek rechthoek1 = new Rechthoek() { Breedte = 2.5,Hoogte = 3.5};
            Console.WriteLine("Breedte rechthoek: " + rechthoek1.Breedte);
            Console.WriteLine("Hoogte rechthoek: " + rechthoek1.Hoogte);
        }
    }
}
