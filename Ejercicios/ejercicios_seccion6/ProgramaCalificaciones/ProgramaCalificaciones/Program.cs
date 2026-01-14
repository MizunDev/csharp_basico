using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            byte i, numAlumnos;
            double sumaCalificaciones = 0, promedio, calificacionMinima = 10, calificacionMaxima = 0;

            // Solicitar el número de alumnos
            Console.Write("Ingrese el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            // Crear un arreglo para almacenar las calificaciones
            double[] calificaciones = new double[numAlumnos];

            // Solicitar las calificaciones de cada alumno con un ciclo for
            for (i = 0; i < numAlumnos; i++)
            {
                Console.Write($"Ingrese la calificación del alumno {i + 1}: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                // Sumar las calificaciones para calcular el promedio
                sumaCalificaciones += calificaciones[i];

                // Determinar la calificación mínima
                if (calificaciones[i] < calificacionMinima)
                {
                    calificacionMinima = calificaciones[i];
                }
                // Determinar la calificación máxima
                if (calificaciones[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones[i];
                }
            }

            // Calcular el promedio
            promedio = sumaCalificaciones / numAlumnos;

            // Mostrar los resultados
            Console.WriteLine($"\nPromedio de calificaciones: {promedio:F3}");

            Console.WriteLine($"Calificación mínima: {calificacionMinima:F2}");

            Console.WriteLine($"Calificación máxima: {calificacionMaxima:F2}");

            // Esperar a que el usuario presione una tecla antes de cerrar
        }
    }
}
