using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mostrarnumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // imprimir los números del 1 al 10
            Console.WriteLine("Números del 1 al 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------"); // separador

            Console.WriteLine("Números del 10 al 1:");

            // imprimir los números del 10 al 1
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // imprimir solo los numeros pares del 1 al 20
            Console.WriteLine("---------------"); // separador
            Console.WriteLine("Números pares del 1 al 20:");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Calcular la suma de los números del 1 al 100.

            Console.WriteLine("---------------"); // separador
            Console.WriteLine("Suma de los números del 1 al 100:");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
                Console.WriteLine(suma);
            }

            // Mostrar la tabla de multiplicar del 5.
            Console.WriteLine("---------------"); // separador
            Console.WriteLine("Tabla de multiplicar del 5:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
        }
    }
}
