using System;

namespace Demo_AutoProperty
{
    public class Rechthoek
    {
        public double Breedte {get; set;} //Auto-property (onderliggend field wordt automatische aangemaakt)
        public double Hoogte { get; set; } //Auto-property 
        public Rechthoek(double breedte, double hoogte)
        {
            this.Breedte = breedte;
            this.Hoogte = hoogte;
        }
    }
    class Program
    {
        static void Main()
        {
            Rechthoek rechthoek1 = new Rechthoek(2.0, 3.0);
            rechthoek1.Breedte = 1.0;
            rechthoek1.Hoogte = 2.0;
            Console.WriteLine("Breedte rechthoek: " + rechthoek1.Breedte);
            Console.WriteLine("Hoogte rechthoek: " + rechthoek1.Hoogte);
        }
    }
}
