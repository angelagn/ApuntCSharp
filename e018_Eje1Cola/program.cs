// See https://aka.ms/new-console-template for more information

/* Ejercicio1:

	- Crea una cola de usuarios "Nombres" para hacer espera para recoger unos premios
	- Imprime todos los usuarios de la cola
	- Borra el primer elemento en salir de la cola
	- Imprime todos los usuarios de nuevo */

using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           // - Crea una cola de usuarios "Nombres" para hacer espera para recoger unos premios
           Queue cola1 = new Queue(); 
            
            cola1.Enqueue("Maria");  
            cola1.Enqueue("juan");
            cola1.Enqueue("Pedro");
            cola1.Enqueue("Enrique");


            //- Imprime todos los usuarios de la cola
            System.Console.WriteLine("Lista 1 *********************");
            foreach(String nombres in cola1){
                System.Console.WriteLine("Valor: " + nombres);
            }

            // - Borra el primer elemento en salir de la cola
            Console.WriteLine("\nBorrando elemento 1'{0}'", cola1.Dequeue() + "\n");

            //- Imprime todos los usuarios de nuevo 
            System.Console.WriteLine("Lista 2 *********************");
            foreach(String nombres in cola1){
                System.Console.WriteLine("Valor: " + nombres);
            }
            
        } 
    }
}