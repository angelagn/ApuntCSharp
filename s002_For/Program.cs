// See https://aka.ms/new-console-template for more information
using System;

namespace EjerciciosClase
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Sin el for
            // Console.WriteLine("2 x 0 = " + (2*0));
            // Console.WriteLine("2 x 1 = " + (2*1));
            // Console.WriteLine("2 x 2 = " + (2*2));
            // Console.WriteLine("2 x 3 = " + (2*3));
            // Console.WriteLine("2 x 4 = " + (2*4));
            // con el for
            for(int i = 0; i <= 10; i++){
                
                 Console.WriteLine("2 x " + i + " = " + (2*i));

            }
        }
    }
}