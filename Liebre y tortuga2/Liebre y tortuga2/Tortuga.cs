using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga2
{
    class Tortuga : Competidor
    {
        public void avanceTortuga()
        {
            int aleatorio = rnd.Next(0, 10);
            if (aleatorio >= 0 && aleatorio <= 4)
                avance += 3;
            else if (aleatorio >= 5 && aleatorio <= 6)
                avance -= 6;
            else
                avance++;

        }
        

    }
}
