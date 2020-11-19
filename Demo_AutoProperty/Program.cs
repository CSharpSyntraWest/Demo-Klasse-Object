using System;

namespace Demo_AutoProperty
{
    public class Cirkel
    {
        private int _x; //private field
        private int _y;//private field
        public int X
        {
            get { return _x; }
            set {
                //input validatie enkel positieve waarden toelaten
                if (X < 0) throw new Exception("Enkel positieve x waarden toegestaan");
                _x = value; 
            
            }
        }
        public int Y
        {
            get { return _y; }
            set {
                //input validatie enkel positieve waarden toelaten
                if (X < 0) throw new Exception("Enkel positieve y waarden toegestaan");
                _y = value;
            }
        }
        //private int myVar;  //propfull <TAB><TAB>

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public double Straal { get; set; } //Auto prop    prop <TAB><TAB>  (auto-property) compiler maakt private field voor deze property
        public string Kleur { get; }//Auto prop enkel leestoegang
        public Cirkel(double straal, string kleur)  //ctor <TAB><TAB>
        {
            Straal = straal;
            Kleur = kleur;
        }
    }
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
            try
            {
                Cirkel cirkel1 = new Cirkel(2, "Rood");
                cirkel1.X = -1;
                cirkel1.Y = 2;
                cirkel1.Straal = 3;
                // Cirkel.Kleur = "Groen"; //lukt niet enkel get (enkel leestoegang)
                Console.WriteLine($"Cirkel Kleur {cirkel1.Kleur} middelpunt({cirkel1.X},{cirkel1.Y}) straal= {cirkel1.Straal}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Rechthoek rechthoek1 = new Rechthoek(2.0, 3.0);
            //rechthoek1.Breedte = 1.0;
            //rechthoek1.Hoogte = 2.0;
            //Console.WriteLine("Breedte rechthoek: " + rechthoek1.Breedte);
            //Console.WriteLine("Hoogte rechthoek: " + rechthoek1.Hoogte);
        }
    }
}
