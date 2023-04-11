// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Queue objetoCola =  new Queue();
            objetoCola.Enqueue(101);
            objetoCola.Enqueue("Hello");
            objetoCola.Enqueue(3.14f);
            objetoCola.Enqueue(true);
            objetoCola.Enqueue(67.8);

            //IMprimir objeto Cola
            foreach (var Temp in objetoCola){ // var recibe el dato como objeto
                Console.WriteLine("Valor inicial: " + Temp);
            }

            // Añadir nuevo elemento
            objetoCola.Enqueue("Rojo");

            //Borrar dos elementos
            objetoCola.Dequeue();
            objetoCola.Dequeue();

            //Recorrer la cola
            foreach(var Temp in objetoCola){
                System.Console.WriteLine("Valor final; " + Temp);
            }
        } 
    }
}
