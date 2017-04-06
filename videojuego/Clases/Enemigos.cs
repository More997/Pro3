using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego.Clases
{
    class Enemigos
    {
        private int x;
        private int y;
        private string enemigo;
        private Random random = new Random();
        public Enemigos()
        {
            x = random.Next(1, 59);
            y = random.Next(1, 59);
            enemigo = "A";
        }
        public void Movimiento()
        {
            switch (random.Next(0, 3))
            {
                case 0:
                    if (x <= 59)
                        x = +1;
                    break;
                case 1:
                    if (x >= 1)
                        x = -1;
                    break;
                case 2:
                    if (y <= 59)
                        y = +1;
                    break;
                case 3:
                    if (y >= 1)
                        y = -1;
                    break;
            }
        }
    }
}

