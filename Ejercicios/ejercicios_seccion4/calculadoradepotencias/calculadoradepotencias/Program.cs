using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoradepotencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula la potencia, ya sea positiva o negativa de un numero con ciclo for

            Console.WriteLine("Calculadora de Potencias");

            // Solicitar al usuario la base y el exponente
            Console.Write("Ingrese la base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el exponente (entero): ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            // Inicializar la variable resultado
            double resultado = 1.0;

            // Calcular la potencia usando un ciclo for
            if (exponente >= 0)
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNum;
                }
            }
            else
            {
                for (int i = 0; i < -exponente; i++)
                {
                    resultado /= baseNum;
                }
            }

            // Mostrar el resultado
            Console.WriteLine($"El resultado de {baseNum} elevado a la {exponente} es: {resultado}");
        }
    }
}
