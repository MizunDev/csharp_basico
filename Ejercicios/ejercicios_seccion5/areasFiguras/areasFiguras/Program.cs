using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areasFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculo de Areas Geometricas
            Console.WriteLine("Calculo de Areas Geometricas");

            // Preguntar al usuario qué figura desea calcular
            Console.WriteLine("Seleccione la figura para calcular el área:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo");
            string opcion = Console.ReadLine();

            // Variables para almacenar las dimensiones
            double radio, lado, @base, altura, area = 0;

            // Calcular el área según la figura seleccionada
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el radio del círculo: ");
                    radio = Convert.ToDouble(Console.ReadLine());
                    area = AreaCirculo(radio);
                    Console.WriteLine($"El área del círculo es: {area}");
                    break;

                case "2":
                    Console.Write("Ingrese el lado del cuadrado: ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    area = AreaCuadrado(lado);
                    Console.WriteLine($"El área del cuadrado es: {area}");
                    break;

                case "3":
                    Console.Write("Ingrese la base del triángulo: ");
                    @base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    area = AreaTriangulo(@base, altura);
                    Console.WriteLine($"El área del triángulo es: {area}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Método para calcular el área del círculo
        static double AreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el área del cuadrado
        static double AreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        // Método para calcular el área del triángulo
        static double AreaTriangulo(double @base, double altura)
        {
            return (@base * altura) / 2;
        }
    }
}
