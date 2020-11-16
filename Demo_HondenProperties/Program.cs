using System;

namespace Demo_HondenProperties
{
    public class Hond
    {
        private string naam;
        private string ras;
        public Hond(string naam, string ras) //constructor met 2 parameters
        {
            this.naam = naam;
            this.ras = ras;
        }
        public string Naam //property met lees-en schrijftoegang
        {
            get { return this.naam; }
            set { this.naam = value; }
        }

        public string Ras // property met enkel leestoegang
        {
            get { return this.ras; }
        }

        public void Spreek()
        {
            Console.WriteLine("{0} zegt: Woef!",
               this.naam ?? "[hond zonder naam]");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hond hond1 = new Hond("Lassie", "Collie");
            Console.WriteLine("Naam :" + hond1.Naam);
            Console.WriteLine("Ras : " + hond1.Ras);
            hond1.Naam = "Fifi";
            //hond1.Ras = "pitbull"; // lukt niet, enkel leestoegang
            hond1.Spreek();
            
        }
    }
}
