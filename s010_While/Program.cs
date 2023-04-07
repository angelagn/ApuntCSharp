// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Program
{

    class Ejercicio
    {
        // Se auto-ejecuta
    public static void Main(string[] args)
        {
            string pass = "";
            while(pass != "Password"){
            Console.WriteLine("Introducir Pwd: ");
            pass = Convert.ToString(Console.ReadLine());
            if(pass == "Password"){
                Console.WriteLine("Ok, Bienvenido");
            }else{
                Console.WriteLine("No entra");
            }
            }
            
        }
    }
}