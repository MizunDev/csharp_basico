using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena1, contrasena2 = "";

            Console.WriteLine("Ingrese la contraseña: ");
            contrasena1 = Console.ReadLine();

            while (contrasena1 != contrasena2)
            {
                Console.WriteLine("Confirme la contraseña: ");
                contrasena2 = Console.ReadLine();
                if (contrasena1 != contrasena2)
                {
                    Console.WriteLine("Las contraseñas no coinciden. Intente de nuevo.");
                }
            }
            Console.WriteLine("Contraseña establecida correctamente.");
        }
    }
}
