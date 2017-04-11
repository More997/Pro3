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
        private bool toqueb;

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
            toqueb = false;
        }

        public void dibujar()
        {
            Console.SetCursorPosition(x, y);
            if (anima == false && toqueb == false)
            {
                Console.WriteLine(pj1);
                anima = true;

            }
            else if (anima == true && toqueb == false)
            {
                Console.WriteLine(pj2);
                anima = false;
            }
            else
                Console.WriteLine(borde);
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
            if (x == min+1|| y == min+1 || x == max || y == max)
                toqueb = true;
            else
                toqueb = false;
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
