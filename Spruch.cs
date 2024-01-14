using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Spruch
    {
        private double _alkoholPromille;

        public Spruch (double alkoholPromille)
        {
            _alkoholPromille = alkoholPromille;
        }   
        public string ErhalteSpruch()
        {
            string spruch = "";
            
            if (_alkoholPromille < 0.5 ||_alkoholPromille == 0.5)
            {
                spruch = "Sie dürfen fahren";
                
            }

            else if (_alkoholPromille > 0.5)
            {
                spruch = "Sie dürfen nicht fahren";
            }
            return _alkoholPromille + spruch;


        }
    }
}
