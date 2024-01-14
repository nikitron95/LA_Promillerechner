using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Person
    {
        public const int MAENNLICH = 0;
        public const int WEIBLICH = 1;
        private const double ABBAU_WARTEZEIT_STUNDEN = 1.0;
        private const double ABBAU_PRO_STUNDE = 0.1;
        private const double ANTEIL_WASSER_IM_BLUT = 0.8;
        private const double DICHTE_BLUT_GRAMM_PRO_CCM = 1.055;

        private double _koerpermasse;
        private double _koerpergrosseInCm;
        private DateTime _geburtsdatum;
        private int _geschlecht;
        private double _alkoholPromille = 0.0;

        public double AlterInJahren
        {
            get
            {
                return DateTime.Now.Subtract(_geburtsdatum).Days / 365.0;
            }
        }
        public double AlkoholPromille
        {
            get
            {
                return _alkoholPromille;
            }
        }

        public double GKW
        {
            get
            {
                double gkw = 0.0;

                if (_geschlecht == 0)
                {
                     gkw = 2.447 - 0.09516 * AlterInJahren + 0.1074 * _koerpergrosseInCm + 0.3362 * _koerpermasse;
                }
                else if (_geschlecht == 1)
                {
                     gkw = 0.203 - 0.07 * AlterInJahren + 0.1069 * _koerpergrosseInCm + 0.2466 * _koerpermasse;
                }
                return gkw ;
            }
        }

        public Person (double koerpermasse, double koerpergroesseInCm, DateTime geburtsdatum, int geschlecht)
        {
            _koerpergrosseInCm = koerpergroesseInCm;
            _geburtsdatum = geburtsdatum;
            _geschlecht = geschlecht;
            _koerpermasse = koerpermasse;
        }

        public void Trinke(Getraenk getraenk)
        {
            _alkoholPromille = ANTEIL_WASSER_IM_BLUT * getraenk.AlkoholmasselnGramm / (DICHTE_BLUT_GRAMM_PRO_CCM * GKW);

            if ( ABBAU_WARTEZEIT_STUNDEN < getraenk.StundenSeitEinahme)
            {
                _alkoholPromille = (getraenk.StundenSeitEinahme - ABBAU_WARTEZEIT_STUNDEN) * ABBAU_PRO_STUNDE;
            }

        }
    }
}
