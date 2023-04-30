// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            LinkedList<String> lista1 = new LinkedList<String>();
            lista1.AddLast("Angela");
            lista1.AddLast("Sofi");
            lista1.AddLast("Pepe");
            lista1.AddLast("Maria");
            //Imprimir la lista
            foreach(string str1 in lista1){
                System.Console.WriteLine(str1);
            }
            //Eliminar el primero y ultimo
            lista1.RemoveFirst();
            lista1.RemoveLast();
            lista1.Remove("pepe");

            //Imprimir de nuevo
             foreach(string str1 in lista1){
                System.Console.WriteLine(str1);
            }
        } 
    }
}
