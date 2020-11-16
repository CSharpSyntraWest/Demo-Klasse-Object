using System;

namespace Demo_Property_Set_Validatie
{
    public class Persoon
    {
        private string naam;
        public Persoon(string naam)
        {
            this.Naam = naam;
        }
        public string Naam
        {
            get { return this.naam; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Ongeldige naam!");
                this.naam = value;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Persoon persoon = new Persoon(""); //lukt niet Foutmelding bij ongeldige naam
            persoon.Naam = ""; //lukt niet, Foutmelding bij ongeldige naam
        }
    }
}
