// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
          
            double num = 2.3;
            switch(num)

            {
                case (<= 0.0):
                System.Console.WriteLine("Loo low");
                break;
                case (> 15.0):
                System.Console.WriteLine("Too Hight");
                break;
                default:
                System.Console.WriteLine("Intermedio: " + num);
                break;
            }


        } 
    }
}
