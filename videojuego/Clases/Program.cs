using System;
using System.IO;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscando archivo existente en caso contrario se creara uno");
            FileStream fs2;
            StreamWriter sw;
            StreamReader sr;
            if (!File.Exists("datosJuegos.txt"))
            {
                FileStream fs = File.Create("datosJuegos.txt");
                Console.WriteLine("Ingrese Mensaje de bienvenida");
                sw = new StreamWriter(fs);
                sw.WriteLine(Convert.ToString(Console.ReadLine()));
                sw.Close();
                fs.Close();

            }
                fs2 = File.OpenRead("datosJuegos.txt");
                sr = new StreamReader(fs2);

            Console.WriteLine("Ingrese un Nombre, por favor");
            string name = Console.ReadLine();
            int highscore=0;
            string tecla = "";
            string nameHS = "";
            bool fin = false;
            bool newHS = false;
            FileStream HS;
            FileStream HSname;
            if (!File.Exists("HS.txt") && !File.Exists("Nombre.txt"))
            {
                FileStream HS = File.Create("HS.txt");
                FileStream HSname = File.Create("Nombre.txt");
            }
            else
            {
                FileStream HS = File.Create("HS.txt");
                FileStream HSname = File.Create("Nombre.txt");
            }
                BinaryWriter HSw = new StreamWriter(HS);
                BinaryReader HSr = new StreamReader(HS);
                StreamWriter Nw = new StreamWriter(HSname);
                StreamReader Nr = new StreamReader(HSname);

           
            videojuego.Clases.Juego game = new videojuego.Clases.Juego();
            do
            {
                Console.WriteLine("\n"+ sr.ReadLine() +" "+ name +"!\n Si quiere jugar toque N\n si quiere salir toque X\n");
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
            sr.Close();
            fs2.Close();
            Console.WriteLine("Fin del juego");
           /* 
            if (newHS == true)
            {
                sw.WriteLine(name);
            }
            */
            
            
        }
    }
}
    

