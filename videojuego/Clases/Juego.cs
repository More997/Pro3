using System;


namespace videojuego.Clases
{
    class Juego
    {
        private bool muerto;
        private int min;
        private int max;
        private int cantE;
        private int cantB;
        private int puntos;
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

        public void Start(ref int highscore, ref bool fin, ref bool newHS)
        {
            Enemigos [] enemigos = new Enemigos[cantE];
            Bombas[] bombas = new Bombas[cantB];
            Personaje pj = new Personaje();
            Bombas[] monedas = new Bombas[15];
            muerto = false;
            puntos = 0;
            for (int i = 0; i < enemigos.Length; i++)
            {
                enemigos[i] = new Enemigos();
            }
            for (int i = 0; i < bombas.Length; i++)
                bombas[i] = new Bombas(true);
            for (int i = 0; i < monedas.Length; i++)
                monedas[i] = new Bombas(false);
            while (muerto == false)
            {
                Console.Clear();
                if (puntos > highscore)
                    highscore = puntos;
                Console.SetCursorPosition(max + 10, 4);
                Console.WriteLine("Puntos: " + puntos);
                Console.SetCursorPosition(max + 10, 6);
                Console.WriteLine("High Score: " + highscore);
                for (int i = 0; i < bombas.Length; i++)
                {
                    Console.SetCursorPosition(bombas[i].GetX(), bombas[i].GetY());
                    Console.WriteLine(bombas[i].Draw());
                }
                for (int i = 0; i < monedas.Length; i++)
                {
                    Console.SetCursorPosition(monedas[i].GetX(), monedas[i].GetY());
                    Console.WriteLine(monedas[i].Draw());
                }
                for (int i = 0; i < enemigos.Length; i++)
                {
                    Console.SetCursorPosition(enemigos[i].GetX(), enemigos[i].GetY());
                    Console.WriteLine(enemigos[i].Draw());
                }
                pj.dibujar();
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey().KeyChar.ToString();
                    pj.Movimiento(tecla, min, max);
                    if (tecla == "x" || tecla == "X")
                    {
                        muerto = true;
                        fin = true;
                    }
                }
                
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
                for (int i = 0; i < monedas.Length; i++)
                {
                    if (pj.GetX() == monedas[i].GetX() && pj.GetY() == monedas[i].GetY())
                    {
                        puntos += 10;
                        monedas[i].setAgarrado(true);
                    }
                }
                for (int i = 0; i < enemigos.Length; i++)
                {
                    enemigos[i].Movimiento();
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
               if (muerto == true && fin == false)
                {
                    Console.WriteLine("Game Over\n Puntaje:" + puntos);
                    if (puntos >= highscore)
                    {
                        Console.WriteLine("Felicidades! Nuevo Record!");
                        newHS = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El High Score es de:" + highscore + " Puntos");
                        Console.ReadKey();
                    }
                    
                }
            }
        }
    }
}
