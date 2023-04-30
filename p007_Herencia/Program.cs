// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Primera obj1 = new Primera();
            obj1.sumar();
            obj1.val1 = 200; //Se cambia el valor a la variable
            obj1.val2 = 300;
            

            int temp = obj1.SumarImprimir(); // guarda el resultado del metodo en una variable
            System.Console.WriteLine("nueva suma "+ temp);
            

            
            Segunda obj2 = new Segunda();
            obj2.sumar(2,5);
        } 
        
        class Primera{
            //2 partes de una clase, variables y todos los metodos
            public int val1 = 5;
            public int val2 = 7;
            public void sumar(){
            System.Console.WriteLine("Suma primera: " +(val1 + val2));
            }
            public int SumarImprimir(){
                 return (val1 + val2);
            }
        }
        }
        class Segunda{
            public int val3= 8;
            //Se diseña el método para que reciba parámetros
            public void sumar(int val1, int val2){ 
                System.Console.WriteLine("Segunda Suma : " + (val1+val2));
            }

        }
        
    }

