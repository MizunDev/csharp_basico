using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; // Operando

            i = 10;

            Console.WriteLine("Valor de i: {0}", i);

            //Incremento como sufijo e imprimimos
            Console.WriteLine("Valor de i con incremento como sufijo: {0}", i++);

            // Imprimimos el valor de i despues del incremento
            Console.WriteLine("Valor de i despues del incremento como sufijo: {0}", i);

            int n = 20;

            Console.WriteLine("---------------------------");

            Console.WriteLine("Valor de n: {0}", n);

            // Decremento como prefijo e imprimimos
            Console.WriteLine("Valor de n con decremento como prefijo: {0}", --n);

            // Imprimimos el valor de n despues del decremento
            Console.WriteLine("Valor de n despues del decremento como prefijo: {0}", n);

        }
    }
}
