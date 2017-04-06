using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            string tecla = "";
            bool fin = false;
            videojuego.Clases.Juego game = new videojuego.Clases.Juego();
            do
            {
                Console.WriteLine("Bienvenido al Juego!\n Si quiere jugar toque N\n si quiere salir toque X");
                tecla = Console.ReadKey().KeyChar.ToString();
                if (tecla == "N" || tecla == "n")
                {
                    fin = game.Start();
                }
                else if (tecla == "X" || tecla == "x")
                {
                    fin = true;
                    
                }
            } while (fin == false);
            Console.WriteLine("Fin del juego");
            
            /* bool end = false;
             bool anima = false;
             bool vivo = true;
             bool sepuede = true;
             string tecla = "";
             /* 
              string pj = "(~O3O)~";
              string pj2 = "(~OwO)~";
              string limite = "(/O_O)/";
              string muerte = "(oX_X)o";
              */
            /*string pj = "O";
            string pj2 = "o";
            string limite = "Q";
           //string muerte = "X";
            int min = 0;
            int max = 50;
            int cantb = max / 4;
            int cante = 2;
            Random random = new Random();
            int x = max / 2;
            int y = max / 2;
            int[] xb = new int[cantb];
            int[] yb = new int[cantb];
            string[] enemigos = new string[cante];
            int[] xe = new int[cante];
            int[] ye = new int[cante];
            int randomNumber;
            int movimiento;
            int i = 0;
            string[] bombas = new string[cantb];
            while (i != cantb)
            {
                randomNumber = random.Next(min + 1, max - 1);
                xb[i] = randomNumber;
                randomNumber = random.Next(min + 1, max - 1);
                yb[i] = randomNumber;
                bombas[i] = "X";
                i++;
            }
             i = 0;
            while (i != cante)
            { 
                randomNumber = 5 + i;
                xe[i] = randomNumber;
                randomNumber = 6 + i; ;
                ye[i] = randomNumber;
                enemigos[i] = "A";
                i++;
            }
            i = 0;
            while (i != cantb)
            {
                if (xb[i] == x && yb[i] == y)
                {
                    x = random.Next(min + 1, max - 1);
                    y = random.Next(min + 1, max - 1);
                }
                i++;
            }
            Console.SetCursorPosition(0, y + 3);
            Console.WriteLine("Bienvenido al Juego, use WASD para mover al personaje(O) y presione x para salir");
            while (end == false)
            {

                i = 0;
                while (i != cantb)
                {
                    Console.SetCursorPosition(xb[i], yb[i]);
                    Console.WriteLine(bombas[i]);
                    i++;
                }
               
               
                Console.SetCursorPosition(xe[0], ye[0]);
                Console.WriteLine(enemigos[0]);
                Console.SetCursorPosition(xe[1], ye[1]);
                Console.WriteLine(enemigos[1]);
                /*Console.SetCursorPosition(xe[2], ye[2]);
                Console.WriteLine(enemigos[2]);
                Console.SetCursorPosition(xe[3], ye[3]);
                Console.WriteLine(enemigos[3]);
                Console.SetCursorPosition(xe[4], ye[4]);
                Console.WriteLine(enemigos[4]);*/
            /*Console.SetCursorPosition(x, y);
            if (vivo == true)
            {

                if (x == max || y == max || x == min + 1 || y == min + 1)
                {
                    sepuede = false;
                    Console.WriteLine(limite);
                }
                else if (x != max || y != max || x != min + 1 || y != min + 1)
                {
                    sepuede = true;

                }
                if (sepuede == true)
                {
                    if (anima == false)
                    {
                        Console.WriteLine(pj);
                        anima = true;
                    }
                    else
                    {
                        Console.WriteLine(pj2);
                        anima = false;
                    }
                }

                //if (Console.KeyAvailable)
                //{
                    tecla = Console.ReadKey().KeyChar.ToString();
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
                    if (tecla == "x" || tecla == "X")
                    {
                        end = true;
                    }
                //}
                i = 0;
                while (i != cantb|| vivo == false)
                {
                    if (x == xb[i] && y == yb[i])
                    {
                        vivo = false;
                    }
                    i++;
                }
                i = 0;
                while (i != cante)
                {
                    movimiento = random.Next(0, 3);
                    switch (movimiento)
                    {
                        case 0:
                            if (xe[i] < max)
                                xe[i] =+ 1;
                            break;
                        case 1:
                            if (xe[i] < min)
                                xe[i] =- 1;
                            break;
                        case 2:
                            if (ye[i] < max)
                                ye[i] = +1;
                            break;
                        case 3:
                            if (ye[i] > min)
                                ye[i] = -1;
                            break;
                    }
                    i++;
                }
                i = 0;
                while (i != cante)
                {
                    if (x == xe[i] && y == ye[i])
                    {
                        vivo = false;
                    }
                    i++;
                }
            }
            Console.Clear();
            //System.Threading.Thread.Sleep(500);
            if (vivo == false)
            {
                Console.SetCursorPosition(x, y);
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("GAME OVER");
                tecla = Console.ReadKey().KeyChar.ToString();
                if (tecla == "x" || tecla == "X")
                {
                    end = true;
                }
            }
            Console.Clear();

        }
            }

    }
        */
        }
    }
}
    

