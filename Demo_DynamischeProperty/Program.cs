using System;

namespace Demo_DynamischeProperty
{
    public class Rechthoek
    {
        private double breedte;
        private double hoogte;

        public Rechthoek(double breedte,double hoogte)
        {
            this.breedte = breedte;
            this.hoogte = hoogte;
        }
        public double Oppervlakte //dynamische property
        {
            get
            {
                return breedte * hoogte;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Rechthoek rechthoek1 = new Rechthoek(2.0, 3.0);
            Console.WriteLine("Oppervlakte rechthoek:" + rechthoek1.Oppervlakte);
        }
    }
}
