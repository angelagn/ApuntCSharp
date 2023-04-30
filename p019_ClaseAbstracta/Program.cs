// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            //Crea objeto
            Perro obj1 = new Perro();
            obj1.animalSound2(); //Imprime metodo definido
            obj1.animalSound(); //Ejecuta Metodo abstracto
            obj1.animalPatas(); //Ejecuta Metodo abstracto
            obj1.animalOjos(); //Ejecuta Metodo abstracto
            
        } 
    }
}
