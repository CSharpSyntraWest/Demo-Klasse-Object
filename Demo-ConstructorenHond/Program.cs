using System;

namespace Demo_ConstructorenHond
{

    public class Hond
    {
        private string naam;
        private string ras;

        public Hond() //parameterloze constructor
        {
            this.ras = "Onbekend";
        }

        public Hond(string naam, string ras) //constructor met 2 parameters
        {
            this.naam = naam;
            this.ras = ras;
        }
        public void Spreek()
        {
            Console.WriteLine("{0} zegt: Woef!",
               this.naam ?? "[hond zonder naam]");
        }
    }
    class Program
    {
        static void Main()
        {
            Hond hond1 = new Hond("Lassie", "Collie");
            hond1.Spreek();
            Hond hond2 = new Hond();
            hond2.Spreek();
        }
    }
}
