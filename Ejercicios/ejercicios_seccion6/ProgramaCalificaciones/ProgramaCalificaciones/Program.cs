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
            byte i, numAlumnos, salones;
            double SumaCalificaciones = 0, promedioCalificaciones = 0, califMax = 0, califMin = 10;

            // Solicitar el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = byte.Parse(Console.ReadLine());

            // Solicitar el número de alumnos por un salon. Ej: Estudiantes salon 1, salon 2, etc.
            for (i = 1; i <= salones; i++)
            {
                Console.Write($"Ingrese el número de alumnos en el salón {i}: ");
                numAlumnos = byte.Parse(Console.ReadLine());
                // Solicitar las calificaciones de los alumnos
                for (byte j = 1; j <= numAlumnos; j++)
                {
                    Console.Write($"Ingrese la calificación del alumno {j} en el salón {i}: ");
                    double calificacion = double.Parse(Console.ReadLine());
                    // Validar calificación
                    while (calificacion < 0 || calificacion > 10)
                    {
                        Console.Write("Calificación inválida. Ingrese una calificación entre 0 y 10: ");
                        calificacion = double.Parse(Console.ReadLine());
                    }
                    SumaCalificaciones += calificacion;
                    // Actualizar calificación máxima y mínima
                    if (calificacion > califMax)
                        califMax = calificacion;
                    if (calificacion < califMin)
                        califMin = calificacion;
                }
                // Calcular el promedio de calificaciones
                promedioCalificaciones = SumaCalificaciones / (salones
                    * numAlumnos);

                // Mostrar resultados
                Console.WriteLine($"\nPromedio de calificaciones: {promedioCalificaciones:F2}");

                Console.WriteLine($"Calificación máxima: {califMax:F2}");

                Console.WriteLine($"Calificación mínima: {califMin:F2}");
            }
        }
    }
}
