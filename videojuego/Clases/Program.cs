using System;
using System.IO;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscando archivo existente en caso contrario se creara uno");
            FileStream fs;
            if (!File.Exists("datosJuego.txt"))
            {
               fs = File.Create("datosJuegos.txt");
            }
            else
            {
               fs = File.OpenWrite("datosJuego.txt");
            }
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Ingrese un Nombre, por favor");
            string name = Console.ReadLine();
            int highscore=0;
            string tecla = "";
            string nameHS = "";
            bool fin = false;
            bool newHS = false;
            videojuego.Clases.Juego game = new videojuego.Clases.Juego();
            do
            {
                Console.WriteLine("\nBienvenido al Juego "+ name +"!\n Si quiere jugar toque N\n si quiere salir toque X\n");
                if (highscore != 0)
                {
                    Console.WriteLine("El High Score es de " + nameHS + " con " + highscore + " puntos ");
                }
                else
                {
                    Console.WriteLine("Actualmente no hay ningun HighScore! Juega y se el primer High Score del juego");
                }
                tecla = Console.ReadKey().KeyChar.ToString();
                if (tecla == "N" || tecla == "n")
                {
                    game.Start(ref highscore, ref fin, ref newHS);
                }
                else if (tecla == "X" || tecla == "x")
                {
                    fin = true;
                    
                }
            } while (fin == false);
            Console.WriteLine("Fin del juego");
            if (newHS == true)
            {
                sw.WriteLine(name);

            }
            sw.Close();
            fs.Close();
        }
    }
}
    

