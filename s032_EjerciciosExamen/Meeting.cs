// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Meeting("Juan");
            System.Console.WriteLine(Meeting("Juan"));
         

            String Meeting(string TempName){
                return "Encantado de Conocerte " + TempName;
            }
        } 
    }
}