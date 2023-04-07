// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 
            function1_Saludar();
            function2_CalcularAprobado();
            function3_CalcularDoble(8);
            System.Console.WriteLine("Pulsar una tecla para terminar."); 
            Console.ReadKey(); // Interrumpe el programa

            //Funciones y procedimientos
            void function1_Saludar(){ //Como hay void y no return es un PROCDIMIENTO
                 System.Console.WriteLine("Hola buenos dias"); 
                 System.Console.WriteLine("Bienvenido");     
            }

            void function2_CalcularAprobado(){
                int varTemp1 = 5;
                 if(varTemp1 >= 5){
                    System.Console.WriteLine("Aprobado"); 
                 }else{
                    System.Console.WriteLine("Suspenso"); 
                 } 
            }
            
            void function3_CalcularDoble(int tempVar){ //tempvar es el parámetro de la función
                System.Console.WriteLine(tempVar * 2);
            }
        } 
        //Métodos
    }
}
