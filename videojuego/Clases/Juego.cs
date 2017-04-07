using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego.Clases
{
    class Juego
    {
        private bool muerto;
        private int min;
        private int max;
        private int cantE;
        private int cantB;
        private string tecla;
        public Juego()
        {
            muerto = false;
            max = 30;
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
            for (int i = 0; i < enemigos.Length; i++)
            {
                enemigos[i] = new Enemigos();
            }
            for (int i = 0; i < bombas.Length; i++)
                bombas[i] = new Bombas();
            while (muerto == false)
            {
                Console.Clear();
                for (int i = 0; i < bombas.Length; i++)
                {
                    Console.SetCursorPosition(bombas[i].GetX(), bombas[i].GetY());
                    Console.WriteLine(bombas[i].Draw());
                }
                for (int i = 0; i < enemigos.Length; i++)
                {
                    Console.SetCursorPosition(enemigos[i].GetX(), enemigos[i].GetY());
                    Console.WriteLine(enemigos[i].Draw());
                }
                pj.dibujar();
                //if (Console.KeyAvailable)
                //{
                    tecla = Console.ReadKey().KeyChar.ToString();
                    pj.Movimiento(tecla, min, max);
                    if (tecla == "x" || tecla == "X")
                    {
                        muerto = true;
                    }
              //  }
                //System.Threading.Thread.Sleep(500);
                for (int i = 0; i < enemigos.Length; i++)
                {
                    enemigos[i].Movimiento();
                }
                for (int i = 0; i < enemigos.Length;i++)
                {
                    if (pj.GetX() == enemigos[i].GetX() && pj.GetY() == enemigos[i].GetY())
                    {
                       muerto = pj.Muerte();
                    }
                }
                for (int i = 0; i < bombas.Length; i++)
                {
                    if (pj.GetX() == bombas[i].GetX() && pj.GetY() == bombas[i].GetY())
                    {
                        muerto = pj.Muerte();
                    }
                }
                for (int i = 0; i < enemigos.Length; i++)
                {
                    enemigos[i].Movimiento();
                }
                Console.Clear();
               
            }
            
            return muerto;
        }
    }
}
