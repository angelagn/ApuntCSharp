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
            System.Console.WriteLine(function1_Saludar());
            System.Console.WriteLine(functionCIFEmpresa());
            string tempCIFEmpresa = functionCIFEmpresa();
            System.Console.WriteLine(tempCIFEmpresa);
            System.Console.WriteLine( function2_CalcularAprobado());
            System.Console.WriteLine(function3_CalcularDoble(30));
           
            //Funciones
            string function1_Saludar(){ //Return y el tipo de variavle de salida
                  return "Hola buenos dias";        
            }
            string functionCIFEmpresa(){
                return "BSD23ED";
            }

            string function2_CalcularAprobado(){
                int varTemp1 = 5;
                string msj = "";
                 if(varTemp1 >= 5){
                    msj = "Aprobado";
                    System.Console.WriteLine("Aprobado"); 
                 }else{
                    msj = "Suspenso";
                    System.Console.WriteLine("Suspenso"); 
                 } 
                return msj;
            }
            
            int function3_CalcularDoble(int tempVar){ //tempvar es el parámetro de la función
                return (tempVar * 2);
            }
        } 
        //Métodos
    }
}

