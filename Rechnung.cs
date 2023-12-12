using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcalc
{
    internal class Rechnung
    {
        #region FieldVar
        private double steuer;
        private double nettopreis;
        #endregion

        #region Properties
        public double Steuer 
        { 
            get { return steuer; }
            set { steuer = value; }
        }

        public double Netto
        {
            get { return nettopreis; }
            set { nettopreis = value; }
        }
        #endregion

        #region Const
        public Rechnung(double steuer, double nettopreis)
        {
            Steuer = steuer;
            Netto = nettopreis;
        }
        #endregion

        #region methods
        public void PrintBruttopreis()
        {
            double brutto = Netto / 100 * (100 + Steuer);
            Console.WriteLine($"Bruttopreis: {brutto.ToString()}");
        }

        public void PrintNettopreis()
        {
            Console.WriteLine($"Nettopreis: {Netto.ToString()}");
        }

        public void PrintRabatt(double Percent)
        {
            double negPercent = (Percent / 100) - 1 ;
            double posPercent = negPercent * -1;
            Console.WriteLine($"Alter Preis: {Netto.ToString()}");
            Console.WriteLine($"Rabatt: {Percent.ToString()}");
            double brutto = Netto / 100 * (100 + Steuer);
            Console.WriteLine($"Brutto Preis: {brutto * posPercent}");
            Console.WriteLine($"Neuer Netto Preis: {Netto * posPercent}");
        }
        #endregion
    }
}
