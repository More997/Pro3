using System;

namespace videojuego.Clases
{
    class Enemigos
    {
        private int x;
        private int y;
        private string enemigo;
        private static Random random = new Random();
        public Enemigos()
        {
            x = random.Next(1, 29);
            y = random.Next(1, 29);
            enemigo = "A";
        }
        public void Movimiento(int i)
        {
            switch (i)
            {
                case 0:
                    if (x <= 29)
                        x = +1;
                    break;
                case 1:
                    if (x >= 1)
                        x = -1;
                    break;
                case 2:
                    if (y <= 29)
                        y = +1;
                    break;
                case 3:
                    if (y >= 1)
                        y = -1;
                    break;
            }
        }
        public int GetX()
        {
            if (x >= 30)
                x = 30;
            else if (x <= 0)
                x = 0;
            return x;
        }
        public int GetY()
        {
            if (y >= 30)
                y = 30;
            else if (y <= 0)
                y = 0;
            return y;
        }
         public string Draw()
        {
            return enemigo;
        }
    }
}

