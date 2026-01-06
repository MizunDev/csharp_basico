using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedio_calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asignación compuesta (x -= 5) == (x = x - 5)
            // acumulador = acumulador + variable == acumulador += variable

            //variables
            byte i, numAlumnos;
            double calificacion, sumaCalificaciones = 0, promedio;

            //solicitar el numero de alumnos
            Console.Write("Ingrese el numero de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //bucle para solicitar las calificaciones
            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingrese la calificacion del alumno {0}: ", i);
                calificacion = Convert.ToDouble(Console.ReadLine());
                sumaCalificaciones += calificacion; // acumulador
            }

            //calcular el promedio
            promedio = sumaCalificaciones / numAlumnos;

            //mostrar el promedio
            Console.WriteLine("El promedio de las calificaciones es: {0}", promedio);
        }
    }
}
