using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asignación compuesta (x -= 5) == (x = x - 5)

            //int i;
            //int contador = 0;

            //for (i = 0; i <= 20; i+=2)
            //{
            //    contador += 1;
            //    Console.WriteLine("{0}, Vuelta del ciclo numero {1} ",i ,contador);
            //}

            //Console.WriteLine("El numero de vueltas que dio el ciclo fue: {0}", contador);

            // acumulador = acumulador + valor_a_sumar == acumulador += valor_a_sumar
            int i;
            int acumulador = 0;
            int precio;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el precio del producto {0}: ", i);
                precio = Convert.ToInt32(Console.ReadLine());
                acumulador += precio;
            }

            Console.WriteLine("El precio total de los 5 productos es: {0}", acumulador);
        }
    }
}
