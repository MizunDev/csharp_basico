using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesSalones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de salones: ");
            int salones = int.Parse(Console.ReadLine());

            string[][] nombres = new string[salones][];
            double[][][] notas = new double[salones][][];

            double sumaTotal = 0;
            int totalNotas = 0;
            double notaMaxTotal = double.MinValue;
            double notaMinTotal = double.MaxValue;

            for (int i = 0; i < salones; i++)
            {
                Console.Write($"\nSalón {i + 1} - Número de alumnos: ");
                int alumnos = int.Parse(Console.ReadLine());

                nombres[i] = new string[alumnos];
                notas[i] = new double[alumnos][];

                double sumaSalon = 0;
                int notasSalon = 0;
                double notaMaxSalon = double.MinValue;
                double notaMinSalon = double.MaxValue;

                for (int j = 0; j < alumnos; j++)
                {
                    Console.Write($"\nNombre del alumno {j + 1}: ");
                    nombres[i][j] = Console.ReadLine();

                    Console.Write($"Cantidad de notas de {nombres[i][j]}: ");
                    int cantNotas = int.Parse(Console.ReadLine());

                    notas[i][j] = new double[cantNotas];

                    for (int k = 0; k < cantNotas; k++)
                    {
                        Console.Write($"Nota {k + 1}: ");
                        double nota = double.Parse(Console.ReadLine());
                        notas[i][j][k] = nota;

                        sumaSalon += nota;
                        sumaTotal += nota;
                        notasSalon++;
                        totalNotas++;

                        if (nota > notaMaxSalon) notaMaxSalon = nota;
                        if (nota < notaMinSalon) notaMinSalon = nota;

                        if (nota > notaMaxTotal) notaMaxTotal = nota;
                        if (nota < notaMinTotal) notaMinTotal = nota;
                    }
                }

                double promedioSalon = sumaSalon / notasSalon;

                Console.WriteLine($"\nResultados Salón {i + 1}:");
                Console.WriteLine($"Promedio: {promedioSalon:F2}");
                Console.WriteLine($"Nota máxima: {notaMaxSalon}");
                Console.WriteLine($"Nota mínima: {notaMinSalon}");
            }

            double promedioTotal = sumaTotal / totalNotas;

            Console.WriteLine("\nRESULTADOS GENERALES");
            Console.WriteLine($"Promedio total: {promedioTotal:F2}");
            Console.WriteLine($"Nota máxima total: {notaMaxTotal}");
            Console.WriteLine($"Nota mínima total: {notaMinTotal}");
        }
    }
}
