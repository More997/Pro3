using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego.Clases
{
    class Bombas
    {
        private int x;
        private int y;
        private string icono;
        private bool agarrado;
        private static Random random = new Random();

        public Bombas(bool _danio)
        {
            x = random.Next(1, 29);
            agarrado = false;
            y= random.Next(1, 29);
            if (_danio == true)
                icono = "X";
            else
                icono = "8";
           

        }
        public void setAgarrado(bool agarrar)
        {
            agarrado = agarrar;
            x = 0;
            y = 0;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public string Draw()
        {
            if (agarrado == false)
                return icono;
            else
                return null;
        }
    }
}
