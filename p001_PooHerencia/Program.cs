// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           Hijo obj1 = new Hijo();
           obj1.Saludar(); 

           Padre obj2 = new Padre();
           obj2.nombre = "Manuel";
           System.Console.WriteLine("Mi padre se llama: "+ obj2.nombre);
        } 
    }

    //Crear clase padre
    class Padre{
        public string nombre;
        public int edad;

        public void Saludar(){
        System.Console.WriteLine("Hola soy tu padre");
    }
    }
    //Herencia a clase hijo
    class Hijo : Padre{

    }
}
