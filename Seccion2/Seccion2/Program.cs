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

            //string nombre;

            ////Solicitamos al usuario que ingrese su nombre
            //Console.Write("¿Cómo te llamas?: ");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Hola {0}, bienvenido", nombre);

            //Convirtiendo una cadena en tipo numérico
            //string entrada;
            //int num1 = 5, num2, resultado;

            //Solicitamos al usuario que ingrese un número
            //Console.Write("Ingresa un número para sumarlo: ");


            //num2 = Int32.Parse(Console.ReadLine());

            //resultado = num1 + num2;

            ////Mostramos el resultado
            //Console.WriteLine("El resultado de la suma es: " + resultado);

            // Realizar un programa de computadora que haga el calculo del área de un rectángulo.

            //variables
            double altura, ancho, area, perimetro;

            //Solicitamos al usuario que ingrese la altura y convertimos a tipo double
            Console.Write("Ingresa la altura del rectángulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Solicitamos al usuario que ingrese el ancho y convertimos a tipo double
            Console.Write("Ingresa la base del rectángulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //Calculamos el área y perímetro
            area = altura * ancho;
            perimetro = 2 * (altura + ancho);

            //Mostramos los resultados en pantalla
            Console.WriteLine("El área del rectángulo es: " + area + " Unidades cuadradas");
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro + " Unidades");
        }
    }
}
