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
            byte[] datos = new byte[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(datos[i]);
            }
        }
    }
}