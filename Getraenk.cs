using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Getraenk
    {
        public const double BIER_ALKOHOLGEHALT = 0.05;
        public const double WEIN_ALKOHOLGEHALT = 0.10;
        public const double SCHNAPS_ALKOHOLGEHALT = 0.40;
        public const double DICHTE_ALKOHOLGEHALT = 0.8;

        private int _volumenInMilliliter;
        private double _alkholgehalt;
        private DateTime _getrunkenAm;

        public double StundenSeitEinahme
        {
            get
            {
                return DateTime.Now.Subtract(_getrunkenAm).Hours / 24.0;
            }
        }
        public double AlkoholmasselnGramm
        {
            get
            {
                double alkoholmasse = 0.0;
                if (_alkholgehalt == 1)
                {
                   alkoholmasse = _volumenInMilliliter * BIER_ALKOHOLGEHALT * DICHTE_ALKOHOLGEHALT ;
                }

                else if (_alkholgehalt == 2)
                {
                   alkoholmasse = _volumenInMilliliter * WEIN_ALKOHOLGEHALT* DICHTE_ALKOHOLGEHALT;
                }

                else if (_alkholgehalt == 3)
                {
                   alkoholmasse = _volumenInMilliliter * SCHNAPS_ALKOHOLGEHALT  * DICHTE_ALKOHOLGEHALT;
                }

                return alkoholmasse;
            }
        }

        

        public Getraenk ( int voulmenInMilliliter, double alkoholgehalt, DateTime getrunkenAm)
        {
            _volumenInMilliliter = voulmenInMilliliter;
            _alkholgehalt = alkoholgehalt;
            _getrunkenAm = getrunkenAm; 
        }


    }
}
