// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
   class Ejercicio
    {
        // Se auto-ejecuta
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero total de días. ");

            int num_dias = int.Parse(Console.ReadLine());
            int anios = 0;
            int meses = 0;
            int semanas = 0;

            while(num_dias > 365){
                anios++;
                num_dias = num_dias - 365;
                Console.WriteLine(num_dias);
            }
            while(num_dias > 30){
                meses++;
                num_dias = num_dias - 30;
            }
            while(num_dias > 7){
                semanas++;
                num_dias = num_dias - 7;

            }
            Console.WriteLine("Hay " + anios + " años");
            Console.WriteLine("Hay " + meses + " meses");
            Console.WriteLine("Hay " + semanas + " semanas");
        }
    }
}
