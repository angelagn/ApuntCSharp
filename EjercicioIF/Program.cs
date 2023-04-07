// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{


    class EjercicioIf
    {
        // Se auto-ejecuta
        static void Main(string[] args)
        {

            long formula = 0;

            Console.WriteLine("Introducir base: ");
            long base1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introducir altura: ");
            long altura = Convert.ToInt64(Console.ReadLine());

            formula = (base1 * altura) / 2;


            Console.WriteLine("El área es: " + formula);

        }
    }
}