using System;

namespace Demo_constFieldInClass
{
    class LuxeArtikel
    {
        private const int BTW = 21; //const field
        private string naam; //variabel field
        private double prijsExcl; //variabel field$
        public void SetNaam(string naam)
        {
            this.naam = naam;
        }
        public string GetNaam()
        {
           return naam;
        }
        public void SetPrijsExcl(double prijsExcl)
        {
            this.prijsExcl = prijsExcl;
        }
        public double GetPrijsExcl()
        {
            return prijsExcl;
        }
        //public void SetBTW(int btw)
        //{
        //    BTW = btw;// waarde veranderen lukt niet (const)
        //}
        public int GetBTW()
        {
            return BTW; //lukt wel
        }
        //Methode toevoegen om prijs Incl btw te berekenen
        public double BerekenPrijsInclBTW()
        {
            double prijsIncl = this.prijsExcl + this.prijsExcl * BTW / 100.0;
            return prijsIncl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LuxeArtikel artikel1 = new LuxeArtikel();
            artikel1.SetNaam("Ring");
            artikel1.SetPrijsExcl(1000.00);
            int btwPerc = artikel1.GetBTW();
            // double prijsIncl = artikel1.GetPrijsExcl() + artikel1.GetPrijsExcl() * btwPerc / 100.0;
            double prijsIncl = artikel1.BerekenPrijsInclBTW();
            Console.WriteLine($"Artikel {artikel1.GetNaam()} : Prijs Incl BTW: {prijsIncl}");
        }
    }
}
