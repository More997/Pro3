using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego.Clases
{
    class Juego
    {
        private bool muerto = false;
        private int min;
        private int max;
        private int cantE;
        private int cantB;
        private string tecla;
        public Juego()
        {
            muerto = false;
            max = 60;
            min = 0;
            cantE = 10;
            cantB = max/2;
            tecla = "";
        }
        public bool Start()
        {
            Enemigos [] enemigos = new Enemigos[cantE];
            Bombas[] bombas = new Bombas[cantB];
            Personaje pj = new Personaje();
            while (muerto == false)
            {
                
                for (int i = 0; i > cantB; i++)
                {
                    Console.SetCursorPosition(bombas[i].getX(), bombas[i].getY());
                    Console.WriteLine(bombas[i].Draw());
                    i++;
                }
                pj.dibujar();
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey().KeyChar.ToString();
                    pj.Movimiento(tecla, min, max);
                    if (tecla == "x" || tecla == "X")
                    {
                        muerto = true;
                    }
                }
                Console.Clear();
                System.Threading.Thread.Sleep(500);
            }
            
            return true;
        }
    }
}
