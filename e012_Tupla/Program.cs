// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Ejercicio5 \n\n"); 

            /*Al crear la tupla hay especificar el tipo a la izq
            y a la derecha indicar tipos y argumentos, es crear un objeto con dos 
            posibles valores*/
            Tuple<string, double> obj1 = new Tuple<string, double>("Angela", 9.2);

            // Se procesa el item 1 de la tupla que es el string
            if(obj1.Item1 == "Angela"){
                System.Console.WriteLine("Bienvenido al curso: " + obj1.Item1);
            }

            // Se procesa el item 2 que es la nota
            String nota = "";
            if(obj1.Item2 > 5.0 && obj1.Item2 <= 10.0){
                nota = "Aprobado";
            }else{
                nota = "Suspenso";
            }


            System.Console.WriteLine("Calificacion cualitativa: " + nota);
        } 
    }
}
