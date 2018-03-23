using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga2
{
    class Competidor
    {
        protected int avance;
        public int Avance => avance;
        static protected Random rnd = new Random();

        public Competidor() => avance = 0;
        public string mostrar() => " está en: " + avance + Environment.NewLine;
    }
}
