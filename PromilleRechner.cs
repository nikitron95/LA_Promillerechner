using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class PromilleRechner
    {
        private Person FragePersonenDaten()
        {
            Console.Write("Tippen Sie '0' für männlich oder '1' für weiblich:");
            int geschlecht = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie Ihre Grösse in cm ein:");
            double koerpergroesseInCm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie Ihre Gewicht ein:");
            double koerpermasse = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie Ihre Geburtsdatum ein:");
            DateTime geburtsdatum = Convert.ToDateTime(Console.ReadLine());

            Person Persone1 = new Person(koerpermasse, koerpergroesseInCm, geburtsdatum, geschlecht);
            return Persone1;
        }

        private Getraenk FrageGetrenkeDaten()
        {
            Console.Write("Was für ein Getränk haben Sie getrunken. Tippen Sie 1 für Bier, 2 für Wein und 3 für Schnaps:");
            int alkoholgehalt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie Trinkdatum und -zeit  ein:");
            DateTime getrunkenAm = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Geben Sie die getrunkene Menge in Milliliter ein:");
            int voulmenInMilliliter = Convert.ToInt32(Console.ReadLine());

            Getraenk getraenk = new Getraenk(voulmenInMilliliter , alkoholgehalt, getrunkenAm);
            return getraenk ;
        }


        public void BerechnePromille()
        {
            Person Persone1 = FragePersonenDaten();
            Getraenk getraenk = FrageGetrenkeDaten();
            Persone1.Trinke(getraenk);
            Spruch spruch = new Spruch(Persone1.AlkoholPromille);
            Console.WriteLine(spruch.ErhalteSpruch());
            
        }

    }
}
