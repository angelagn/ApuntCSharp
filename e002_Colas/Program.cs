// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 

            //Crear e inicializar un OBJETO tipo cola
            Queue cola1 = new Queue(); 
           // Queue<string> numbers = new Queue<string>();
            cola1.Enqueue("Invitado1");  //Añade elementos a la cola
            cola1.Enqueue("Invitado2");
            cola1.Enqueue("Invitado3");
           
            

            //Saber numero de elementos de la cola
            int totalCola = cola1.Count;
            System.Console.WriteLine("Numero de elementos de la cola: " + totalCola);

            // foreach(String Temporal in cola1){
            //     System.Console.WriteLine("Valor: " + Temporal);
            // }

            //Interrupción I
            Console.ReadKey();

            //Primer elemento en abandonar la cola
            string nextvalue = cola1.Peek().ToString();
            Console.WriteLine("Proximo: " + nextvalue);
            Console.ReadKey();
        //     // cola1.Clear(); // Elimina el contenido de la cola
        //     // cola1.Peek(); // indica quien es el primero de la cola

        //    //Eliminar el primero de la cola
        cola1.Dequeue();
        ImprimirValores(cola1);

        foreach(String Temporal in cola1){
            System.Console.WriteLine("Valor: " + Temporal);
        }
        Console.ReadKey();
        //     string siguiente = cola1.Peek().ToString();
        //     Console.WriteLine("Proximo: " + nextvalue);
        //     Console.ReadKey();


        cola1.Dequeue();
        ImprimirValores(cola1);
        //     foreach(String Temporal in cola1){
        //             System.Console.WriteLine("Valor: " + Temporal);
        //     }

            ImprimirValores(cola1);

            void ImprimirValores(IEnumerable miColeccionTemporal){
                foreach(String Temporal in miColeccionTemporal){
                    System.Console.WriteLine("Valor: " + Temporal);
                }
            }
        
        }
    }
}
