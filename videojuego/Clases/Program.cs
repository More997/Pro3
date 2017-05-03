using System;
using System.Net;
using System.IO;

using Newtonsoft.Json.Linq;

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

            if (!File.Exists("HS.txt") )
            {
                HS = new FileStream("HS.txt", FileMode.Create);
                HS.Close();

            }
            else if (File.Exists("HS.txt"))
            {
                BinaryReader BRHS = new BinaryReader(File.Open("HS.txt", FileMode.Open));
                highscore = BRHS.ReadInt32();
                nameHS = BRHS.ReadString();
                BRHS.Close();
            }
            BinaryWriter BWHS = new BinaryWriter(File.Open("HS.txt", FileMode.Open));
            
            WebRequest req = WebRequest.Create("https://query.yahooapis.com/v1/public/yql?q=select%20item.condition.text%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22buenos%20aires%2C%20tx%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");

            WebResponse respuesta = req.GetResponse();

            Stream stream = respuesta.GetResponseStream();

            StreamReader str = new StreamReader(stream);
            JObject data = JObject.Parse(str.ReadToEnd());
            string clima;
            try
            {
                
                clima = (string)data["query"]["results"]["channel"]["item"]["condition"]["text"];
            }
            catch (Exception error)
            {
                clima = " ";
            }
            switch (clima)
            {
                case "Sunny":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "Cloudy":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "Rainy":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
            videojuego.Clases.Juego game = new videojuego.Clases.Juego();
            Console.WriteLine("\n" + sr.ReadLine() + " " + name+"!");
            
            do
            {
                Console.WriteLine("Si quiere jugar toque N\n si quiere salir toque X");
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

                if (newHS == true)
                {
                    nameHS = name;
                    BWHS.Write(highscore);
                    BWHS.Write(name);
                }
                else if (highscore == 0)
                {
                    BWHS.Write(highscore);
                    BWHS.Write("");
                }
            } while (fin == false);
            sr.Close();
            fs2.Close();
            BWHS.Close();
            Console.WriteLine("Fin del juego");
        
            
            
        }
    }
}
    

