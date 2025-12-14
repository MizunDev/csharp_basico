using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_y_normalize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona una opcion: ");
            Console.WriteLine(" 1. Jugar");
            Console.WriteLine(" 2. Opciones");
            Console.WriteLine(" 3. Salir");

            string opcion = Console.ReadLine();

            opcion = opcion.ToLower();

            //Console.WriteLine("Has seleccionado: " + opcion);

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Iniciando juego 🎮");
                    break;

                case "2":
                    Console.WriteLine("Configuraciones ⚙️");
                    break;

                case "3":
                    Console.WriteLine("Chao pues 👋");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
