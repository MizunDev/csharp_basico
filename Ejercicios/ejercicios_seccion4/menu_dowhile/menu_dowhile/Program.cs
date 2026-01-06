using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu de operaciones con do while
            // Variable para la opcion del menu
            byte opcion;
            // Variable para el resultado de la operacion
            decimal num1, num2, resultado = 0M;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu de Operaciones");
                Console.WriteLine("1. Sumar dos numeros");
                Console.WriteLine("2. Restar dos numeros");
                Console.WriteLine("3. Multiplicar dos numeros");
                Console.WriteLine("4. Dividir dos numeros");

                // Leer la opcion del usuario
                Console.Write("Seleccione una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

            }
            while (opcion < 1 || opcion > 4);

            // Pedimos los numeros al usuario
            Console.Write("Ingrese el primer numero: ");
            num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = decimal.Parse(Console.ReadLine());

            // Realizamos la operacion segun la opcion seleccionada
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la division es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}
