using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            ulong i, numero, factorial = 1;

            // Input
            Console.Write("Ingrese un numero entero positivo para calcular su factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            // Process
            for (i = numero; i >= 1; i--)
            {
                factorial = factorial * i; // factorial *= i;
            }

            // Output
            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
        }
    }
}
