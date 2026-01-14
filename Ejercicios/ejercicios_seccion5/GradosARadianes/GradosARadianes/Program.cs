using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosARadianes
{
    internal class Program
    {
        // Método para convertir grados a radianes
        public static double GradosARadianes(double grados)
        {
            return grados * (Math.PI / 180);
        }
        static void Main(string[] args)
        {
            // Calculadora de grados a radianes
            Console.WriteLine("Calculadora de Grados a Radianes");

            // Solicitar al usuario que ingrese el valor en grados
            Console.Write("Ingrese el valor en grados: ");
            double grados = Convert.ToDouble(Console.ReadLine());

            // Convertir grados a radianes
            double radianes = GradosARadianes(grados);

            // Mostrar el resultado
            Console.WriteLine("{0}° = {1} radian", grados, radianes);
        }
    }
}