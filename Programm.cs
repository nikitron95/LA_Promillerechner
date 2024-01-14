using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Programm
    {
        public static void Main (string[] args)
        {
            PromilleRechner promilleRechner = new PromilleRechner();

            promilleRechner.BerechnePromille();
        }
    }
}
