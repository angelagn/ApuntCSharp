// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // Crear una cola
            Queue personas = new Queue();
            personas.Enqueue("Angela");
            personas.Enqueue("Luis");
            personas.Enqueue("Antonio");
            personas.Enqueue("Enrique");

            System.Console.WriteLine("Numero de elementos {0}" , personas.Count);

            //Recorre el objeto
            foreach (string Temp in personas){
                System.Console.WriteLine("Valor: " + Temp);
            }

            personas.Enqueue("Mercedes");

            // convertir cola en tabla
            // crear una tabla

            object[] copiaCola = new object[5]; // Crea un array de objetos, está vacío
            //Transforma la cola en un array desde el índice cero
            personas.CopyTo(copiaCola, 0); // se pasa el array y el indice desde el que quiero copiar

            for (int i=0; i<5; i++){
                System.Console.WriteLine("Valor Array; " + copiaCola[i]);
            }

            // Posicion impar, desde indice cero
             for (int i=0; i<5; i=i+2){ 
                System.Console.WriteLine("Valor Array; " + copiaCola[i]);
            }

              // Posicion par, desde índice 1
             for (int i=1; i<5; i=i+2){
                System.Console.WriteLine("Valor Array; " + copiaCola[i]);
            }

            //Imprimir array
            foreach(string temp in copiaCola){
                System.Console.WriteLine("Impirmir Array " + temp);
            }


        } 
    }
}
