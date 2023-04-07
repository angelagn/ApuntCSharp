// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            /*3. Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés. */

            Console.WriteLine("Ingrese tres letras: ");
            String letras = Console.ReadLine();
            string invertida = "";
            foreach(char letra in letras){
                invertida = letra + invertida;
            }
            System.Console.WriteLine(invertida);
        } 
    }
}