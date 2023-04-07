// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{

    class Ejercicio
    {
        // Se auto-ejecuta
    public static void Main(string[] args)
        {
            int num = 0;
            do{
                Console.Write(num);
                num = num + 1;
            }while(num < 5);
        }
    }
}