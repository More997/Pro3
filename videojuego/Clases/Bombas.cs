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
        private string bomba;
        private Random random = new Random();
        public Bombas()
        {
            x= random.Next(1, 59);
            y= random.Next(1, 59);
            bomba = "X";
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
            return bomba;
        }
    }
}
