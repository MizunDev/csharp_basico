using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bool decision;
            //decision = true;

            //int a = 30, b = 20;

            //Console.WriteLine(5 != 5);

            //Console.WriteLine(-30.0 < 3.5);

            //Console.WriteLine(50 > 3500.7);

            //Console.WriteLine((5 + 5) >= 5);

            // Pedir un número al usuario y determinar si es positivo o negativo
            // Variables

            double numero;
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }

        }
    }
}
