// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{

    class Ejercicio
    {
        // Se auto-ejecuta
    public static void Main(string[] args)
        {
            // objeto var = objeto
            var Loteria2 = new List<int>{23, 11, 13, 7, 16, 33};// new List<int>{}; crea un nuevo objeto de la clase lista

            foreach(int tempValue in Loteria2){ // vamos a recorrer el objeto con la palabra reservada in
                Console.WriteLine($"{tempValue}");
            }

        }
    }
}