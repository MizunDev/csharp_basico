using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 8;
            //double num2 = 4.5;
            //double resultado;

            ////Sumamos las dos variables
            ////resultado = num1 + num2;

            ////Sumando una variable y un dato puesto explícitamente
            //resultado = num1 + 22;

            //Console.WriteLine(resultado);

            //string saludo = "Hola";
            //string nombre = "Elisabeth";

            ////Sumando dos cadenas de texto almacenadas en variables (concatenación)
            //Console.WriteLine(saludo + " " + nombre + " ¿Cómo estás?");

            //Usando el operador "rest" (-)
            //Console.WriteLine(50 - 8);

            //Usando el operador "multiplicación" (*)
            //Console.WriteLine(2 * 2);

            //Usando el operador "división" (/)
            //Console.WriteLine(12 / 6);

            //Usando el operador "módulo" (%)
            //Console.WriteLine(5.9 % 3.1);

            //Prioridad de operadores
            //Multiplicación y división tienen mayor prioridad que suma y resta (Multiplicacion, Division, Modulo)
            //Suma, Resta

            //double resultado;

            //resultado = (3 / 3) + (5 * 2);

            //Console.WriteLine(resultado); 

            string nombre;

            //Solicitamos al usuario que ingrese su nombre
            Console.Write("¿Cómo te llamas?: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}, bienvenido", nombre);
        }
    }
}
