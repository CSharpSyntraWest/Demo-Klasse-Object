using System;
using System.Collections.Generic;

namespace Demo_Klasse_Object
{
    public class Hond
    {
        private string naam;
        private string ras;

        public void SetNaam(string naam)
        {
            this.naam = naam;
        }
        public string GetNaam()
        {
            return this.naam;
        }
        public void SetRas(string ras)
        {
            this.ras = ras;
        }
        public string GetRas(string ras)
        {
            return this.ras;
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
            Hond hond1 = new Hond();
            hond1.SetNaam("Lassie");
            hond1.SetRas("Collie");
            hond1.Spreek();

            Hond hond2 = new Hond();
            hond2.SetRas("Onbekend");
            hond2.Spreek();

            //Hond hond3 = new Hond();
            //hond3.SetNaam("Bobby");

            //Hond hond4 = new Hond();
            //hond4.SetNaam("Fifi");


            //List<Hond> honden = new List<Hond>();
            //honden.Add(hond3);
            //honden.Add(hond4);
            //honden.Add(hond2);
            //foreach (Hond hond in honden)
            //{
            //    hond.Spreek();
            //}
        }
    }
}
