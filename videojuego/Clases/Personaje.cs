using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego.Clases
{
    class Personaje
    {
        private int x;
        private int y;
        private string pj1;
        private string pj2;
        private bool anima;
        private string borde;
        private bool killed;
        private string pjmuerto;
        public Personaje()
        {
            x = 30;
            y = x;
            pj1 = "O";
            pj2 = "o";
            borde = "Q";
            pjmuerto = "0";
            anima = false;
            killed = false;
        }
        public void dibujar()
        {
            Console.SetCursorPosition(x, y);
            if (anima == false)
                Console.WriteLine(pj1);
            else
                Console.WriteLine(pj2);
        }
        public void Movimiento(string tecla, int min, int max)
        {
            if (tecla == "w" && y > min + 1 || tecla == "W" && y > min + 1)
            {
                y -= 1;
            }
            if (tecla == "s" && y <= max - 1 || tecla == "S" && y <= max - 1)
            {
                y += 1;
            }
            if (tecla == "a" && x > min + 1 || tecla == "A" && x > min + 1)
            {
                x -= 1;
            }
            if (tecla == "d" && x <= max - 1 || tecla == "D" && x <= max - 1)
            {
                x += 1;
            }
        }
        public bool Muerte()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(pjmuerto);
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("GAME OVER");
            return killed =true;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
    }
}
