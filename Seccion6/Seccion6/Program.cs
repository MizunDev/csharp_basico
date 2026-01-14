using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i; //Variable de control del ciclo

            // tipo[] nombre = new tipo[tamaño];
            string[] nombres = new string[3];

            for(i = 0; i <= 2; i++)
            {
                Console.Write("Ingresa el valor para el indice {0}: ", i);
                nombres[i] = Console.ReadLine();
            }

            // Mostramos los valores
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}