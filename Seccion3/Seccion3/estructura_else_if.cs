using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    internal class estructura_else_if
    {
        // Se necesita un programa que realice las operaciones aritméticas básicas: suma, resta, multiplicación y división, a partir de dos números, la operación se elige mediante un menú por parte del usuario usando else if anidados

        // Variables
        decimal num1, num2, resultado = 0m;
        byte opcion;

        public void Calcular()
        {
            // Mostramos el menú de opciones
            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos los números
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Realizamos la operación según la opción elegida

            // si opcion es 1, suma
            if (opcion == 1)
            {
                // Realizamos la suma
                resultado = num1 + num2;
                // Mostramos el resultado
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            // si opcion es 2, resta
            else if (opcion == 2)
            {
                // Realizamos la resta
                resultado = num1 - num2;
                // Mostramos el resultado
                Console.WriteLine("El resultado de la resta es: {0}", resultado);
            }
            // si opcion es 3, multiplicación
            else if (opcion == 3)
            {
                // Realizamos la multiplicación
                resultado = num1 * num2;
                // Mostramos el resultado
                Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
            }
            // si opcion es 4, división
            else if (opcion == 4)
            {
                // Verificamos que el divisor no sea cero
                if (num2 != 0)
                {
                    // Realizamos la división
                    resultado = num1 / num2;
                    // Mostramos el resultado
                    Console.WriteLine("El resultado de la división es: {0}", resultado);
                }
                // si el divisor es cero, mostramos un mensaje de error
                else
                {
                    // Mensaje de error
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
            }
        }
    }
}
