using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Acceder a una matriz escalonada con length y GetLength
            int i; // Cilco exterior
            int j; // Ciclo interior

            double [][] matrizEscalonada = new double[4][]
            {   new double[] {1.1, 2.2, 3.3},
                new double[] {4.4, 5.5},
                new double[] {6.6, 7.7, 8.8, 9.9},
                new double[] {10, 215, 125}
            };

            for (i = 0; i < matrizEscalonada.Length; i++)
            {
                Console.WriteLine("Fila {0} tiene {1} columnas.", i, matrizEscalonada[i].Length);
                for (j = 0; j < matrizEscalonada[i].Length; j++)
                {
                    Console.WriteLine("   Valor de la columna {0} es {1}", j, matrizEscalonada[i][j]);
                }
            }

        }
    }
}