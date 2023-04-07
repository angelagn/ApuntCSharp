// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Introducir nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Introducir contraseña ");
            int passw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducir frase secreta: ");
            String fraseSecreta = Console.ReadLine();

            String usuNombre = "Angela";
            int usuPass = 1234;
            String usuFrase = "Hola Mundo";

            if (usuNombre == nombre && usuPass == passw && usuFrase == fraseSecreta){
                System.Console.WriteLine("OK USUARIO LOGUEADO.");
            }else{
                System.Console.WriteLine("USUARIO NO LOGUEADO.");
            }

        } 
    }
}
