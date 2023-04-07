// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class Ejercicio
    {
        // Se auto-ejecuta
        static void Main(string[] args)
        {
        //     Console.WriteLine("Hello, World!");

        //     int num1 = 7;
        //     Console.WriteLine("Valor: " + num1);
            // Se crea un array, una coleccion de datos, no se controla el tamaño porque l
            //porque el espacio entre los corchetes está vacío

            int[] loteria = { 23, 11, 13, 16, 7, 33 };
            ChangeArray(ref loteria);

            // Console.WriteLine(loteria[0]); // Accede a posicion cero
            // Console.WriteLine(loteria[2]); // Accede a posicion 3
            // Console.WriteLine(loteria[2] + loteria[0]); // suma los valores en las posiciones


            //Para imprimir todo el array

            // for (int i = 0; i <= 4; i++)
            // {
            //     Console.WriteLine(loteria[i]);
            //     // Console.WriteLine($"{loteria[0]} + { loteria[2]}");
            // }
            // Función que cambia los valores del array
            void ChangeArray(ref int[] parametroArray){ //parametroArray es una variable temporal y el ref trae todo el objeto array
                parametroArray[0] = 77;
                Console.WriteLine("valor: " +parametroArray[0]);
                Console.WriteLine(loteria);
                Console.WriteLine(ChangeArray);

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(parametroArray[i]);
                    // Console.WriteLine($"{loteria[0]} + { loteria[2]}");
                }

            }
        }
    }
}
