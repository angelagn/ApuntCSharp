// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{

    public class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            if (age < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad");
            }
            if (age >= 5 && age <= 10)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad");
            }
            // MODO 3 DE IF.... else if ... else
            if (age >= 5 && age <= 10)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else if (age >= 18 && age <= 99)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Debes de ser un niño");

            }

        }
    }
}