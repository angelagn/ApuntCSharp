// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            
            int mediaNotas(params int[] notas){
                int suma = 0; 
                foreach(int i in notas){
                    suma = suma + i;
                }
                int result = suma / 4; 
                return result;
            }
            Console.WriteLine("Resultado: " + mediaNotas(5,7,8, 10));
        } 
    }
}
