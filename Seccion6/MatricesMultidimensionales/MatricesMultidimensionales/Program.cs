using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int i; // Variable de control del ciclo externo
            int j; // Variable de control del ciclo interno
            //tipo de dato[,] nombreMatriz = new tipo de dato[filas,columnas];
            double[,] ventas = new double[4, 3] { {100, 120, 205}, 
                                                  {115, 196, 300}, 
                                                  {157, 172, 245}, 
                                                  {130, 180, 281} };

            //ciclo para recorrer filas
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Ventas de la tienda No. {0}", i + 1);
                //ciclo para recorrer columnas
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("  Mes {0}: {1}", j + 1, ventas[i, j]);
                }
            }


        }
    }
}
