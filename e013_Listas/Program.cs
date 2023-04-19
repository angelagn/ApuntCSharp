// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 
            
            //Declaro la pila
            //Stack  obj1 = new Stack();
            ArrayList obj1 = new ArrayList();

            //Meter datos

            obj1.Add("Pan");
            obj1.Add("Lechuga");
            obj1.Add("Leche");
            obj1.Add("Huevos");
            

            //Imprimir la lista
            System.Console.WriteLine("Lista 1");
            foreach(string x in obj1){
                System.Console.WriteLine("Cosas por comprar: " + x);
            }

            //Borrar elemento concreto por nombre
            obj1.Remove("Leche");
            


             //Imprimir la lista
             System.Console.WriteLine("Lista 2");
            foreach(string x in obj1){
                System.Console.WriteLine("Cosas por comprar2: " + x);
            }

            //Borrar elemento concreto por numero
            obj1.RemoveAt(0);

               //Imprimir la lista
            System.Console.WriteLine("Lista 3");
            foreach(string x in obj1){
                System.Console.WriteLine("Cosas por comprar2: " + x);
            }
        } 
    }
}