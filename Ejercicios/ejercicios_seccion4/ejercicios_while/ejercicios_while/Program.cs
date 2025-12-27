using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir números al usuario y sumarlos hasta que ingrese 0
            //int numero, suma = 0;
            //while (true)
            //{
            //    Console.WriteLine("Ingrese un número (0 para terminar): ");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero == 0)
            //    {
            //        break;
            //    }
            //    suma += numero;
            //    Console.WriteLine("Suma parcial: " + suma);
            //}

            // Pedir una contraseña hasta que sea "1234".
            //string contraseña;
            //while (true)
            //{
            //    Console.WriteLine("Ingrese la contraseña: ");
            //    contraseña = Console.ReadLine();
            //    if (contraseña == "1234")
            //    {
            //        Console.WriteLine("Contraseña correcta.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
            //    }
            //}

            // Contar cuántos números positivos ingresa el usuario hasta que ingrese un negativo.
            //int numero, contador = 0;
            //while (true)
            //{
            //    Console.WriteLine("Ingrese un número (negativo para terminar): ");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero < 0)
            //    {
            //        break;
            //    }
            //    contador++;
            //    Console.WriteLine("Cantidad de números positivos ingresados: " + contador);
            //}

            //Mostrar números aleatorios del 1 al 10 hasta que salga un 7
            //Random random = new Random();
            //int numero;
            //while (true)
            //{
            //    numero = random.Next(1, 11);
            //    Console.WriteLine("Número aleatorio: " + numero);
            //    if (numero == 7)
            //    {
            //        Console.WriteLine("Salió un 7, terminando el programa.");
            //        break;
            //    }
            //}

            // Simular un menú que se repite hasta que el usuario elija salir.
            //Console.WriteLine("Menú:");
            //int opcion;

            //while (true)
            //{
            //    Console.WriteLine("1. Opción 1");
            //    Console.WriteLine("2. Opción 2");
            //    Console.WriteLine("3. Opción 3");
            //    Console.WriteLine("4. Opción 4");
            //    Console.WriteLine("5. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    opcion = int.Parse(Console.ReadLine());
            //    if (opcion == 5)
            //    {
            //        Console.WriteLine("Saliendo del menú.");
            //        break;
            //    }
            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Ha seleccionado la Opción 1.");
            //            break;
            //        case 2:
            //            Console.WriteLine("Ha seleccionado la Opción 2.");
            //            break;
            //        case 3:
            //            Console.WriteLine("Ha seleccionado la Opción 3.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Ha seleccionado la Opción 4.");
            //            break;
            //        default:
            //            Console.WriteLine("Opción inválida, intente de nuevo.");
            //            break;
            //    }
            //}

            Console.WriteLine("Presione una tecla para salir...");
        }
    }
}
