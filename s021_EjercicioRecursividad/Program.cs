// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine(recursividad(5));
            int recursividad(int num){
                if (num == 0)  return 1;
                return num* (recursividad(num-1));
            }
        } 
    }
}
