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
            //tipo de dato[,] nombreMatriz = new tipo de dato[filas,columnas];
            double[,] ventas = new double[4, 3] { {100, 120, 205}, 
                                                  {115, 196, 300}, 
                                                  {157, 172, 245}, 
                                                  {130, 180, 281} };

            // Declaracion e instancia de matriz de 3 dimensiones
            int[,,] matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                                  { { 7, 8, 9 }, { 10, 11, 12 } } };
        }
    }
}
