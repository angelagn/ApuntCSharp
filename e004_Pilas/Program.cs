// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            //Pilas

            Stack obj1 = new Stack(); // Crea un objeto de la clase pila
            obj1.Push("Plato1");
            obj1.Push("Plato2");
            obj1.Push("Plato3");
            obj1.Push("Plato4");
            obj1.Push("Plato5");

            //Numero de elementos
            System.Console.WriteLine("Numero de elemmentos: " + obj1.Count);

            // Recorrer elementos
            foreach(string Temp in obj1){
                System.Console.WriteLine("Vlaores primera vez; " + Temp);
            }

            //Quitar elementos

            obj1.Pop(); //La funcion quita un elemento
            obj1.Pop();
            System.Console.WriteLine("Limpiando plato " + obj1.Pop()); 
            // Recorrer elementos para verificar
            foreach(string Temp in obj1){
                System.Console.WriteLine("Vlaores primera vez; " + Temp);
            }

            // FUncion
            ImprimirValores(obj1);
            void ImprimirValores(IEnumerable objTemp){
                 foreach(string Temp in objTemp){
                System.Console.WriteLine("Valores tercera vez:  " + Temp);
                }
            }
        } 
    }
}
