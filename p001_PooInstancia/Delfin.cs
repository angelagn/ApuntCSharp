using System;
namespace HelloWorld 
{ 
    class Delfin{

        /*Método ya no es funcion o procedomiento, 
        estas solo se pueden crear en el main, es lo mismo, solo que el metodo está
        fuera del main*/

        public static string NombreAnimal = "Flipper";
        public void Saludar(){
            System.Console.WriteLine("Hola soy un delfin, y me llamo \n" + NombreAnimal);
        }

        public void Nadar(){
            System.Console.WriteLine("Estoy Nadando...");
        }

         public void Bucear(){
            System.Console.WriteLine("Estoy Buceando...");
        }

    }
    
}