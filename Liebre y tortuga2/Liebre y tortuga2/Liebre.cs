using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga2
{
    class Liebre : Competidor
    {
     

        public void avanceLiebre()
        {
            switch(rnd.Next(0,10))
            {
                case 0: case 1: break;
                case 2: case 3: avance += 9;  break;
                case 4: avance -= 12;  break;
                case 5: case 6: case 7: avance++; break;
                default: avance -= 2; break;
            }


        }
    }
}
