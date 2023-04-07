// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{

    class Ejercicio
    {
        // Se auto-ejecuta
    public static void Main(string[] args)
        {
            
            Console.WriteLine("Texto reconocido");
            goto salto1;
            Console.WriteLine("No imprimible");

            salto1:
                  Console.WriteLine("He dado salto");


        }
    }
}
