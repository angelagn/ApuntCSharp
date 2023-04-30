using System;
using System.Collections;

namespace Examen_M2

{ 
    public class Ejercicio3 
    { 
        public void solucion3() 
        { 
            Console.Clear();
            
            Console.WriteLine("Ejecutando ejercicio numero 3\n");

            //Creo la pila
            Stack pila = new Stack();

            //Añado valores a la pila
            pila.Push("POP");
            pila.Push("Rock and Roll");
            pila.Push("Jazz");
            pila.Push("Disco");
            pila.Push("House");
            pila.Push("Tecno");
            pila.Push("Blues");
            pila.Push("Rhythm and Blues");
            pila.Push("Funk");

            //Creo la lista
            List<string> lista = new List<string>();

            //Añado valores a la lista
            lista.Add("POP");
            lista.Add("Rock and Roll");
            lista.Add("Jazz");
            lista.Add("Disco");
            lista.Add("House");
            lista.Add("Tecno");
            lista.Add("Blues");
            lista.Add("Rhythm and Blues");
            lista.Add("Funk");
            
            //Creo la cola
            Queue cola = new Queue();

            //Añado valores a la cola
            cola.Enqueue("POP");
            cola.Enqueue("Rock and Roll");
            cola.Enqueue("Jazz");
            cola.Enqueue("Disco");
            cola.Enqueue("House");
            cola.Enqueue("Tecno");
            cola.Enqueue("Blues");
            cola.Enqueue("Rhythm and Blues");
            cola.Enqueue("Funk");

            Console.WriteLine("======== Gustos Musicales ========");

            Console.WriteLine("\nLos elementos en la Pila son: ");
            foreach(string temp in pila){
                Console.WriteLine(temp);
            }

            Console.ReadKey();

            Console.WriteLine("\nLos elementos en la Lista son: ");
            foreach(string temp in lista){
                Console.WriteLine(temp);
            }

            Console.ReadKey();

            Console.WriteLine("\nLos elementos en la Cola son: ");
            foreach(string temp in cola){
                Console.WriteLine(temp);
            }

            Console.ReadKey();

            //Pila To Array
            object[] copiaPila = new object[9];
            pila.CopyTo(copiaPila,0);   //Transforma la pila en array desde el indice 0

            //Lista to Array
            string[] copiaLista = lista.ToArray();

            //Cola To Array
            object[] copiaCola = new object[9];
            cola.CopyTo(copiaCola,0);   //Transforma la cola en array desde el indice 0

            //Añado 2 elementos a la Pila
            pila.Push("Clasica");
            pila.Push("Electronica");

            //Añado 2 elementos a la Lista
            lista.Add("Clasica");
            lista.Add("Electronica");

            //Añado 2 elementos a la Cola
            cola.Enqueue("Clasica");
            cola.Enqueue("Electronica");

            Console.WriteLine("\nSe han convertido los datos a Array... ");

            Console.ReadKey();

            Console.WriteLine("\nSe han añadido los elementos: Clasica y Electronica");

            Console.ReadKey();

            Console.WriteLine("======== Gustos Musicales Actualizados ========");

            Console.WriteLine("\nAhora los elementos en la Pila son: ");
            foreach(string temp in pila){
                Console.WriteLine(temp);
            }

            Console.WriteLine("\nMientra los elementos en el Array-Pila son: ");
            foreach(string temp in copiaPila){
                Console.WriteLine(temp);
            }

            Console.ReadKey();

            Console.WriteLine("================");

            Console.WriteLine("\nAhora los elementos en la Lista son: ");
            foreach(string temp in lista){
                Console.WriteLine(temp);
            }

            Console.WriteLine("\nMientra los elementos en el Array-Lista son: ");
            foreach(string temp in copiaLista){
                Console.WriteLine(temp);
            }

            Console.ReadKey();

            Console.WriteLine("================");

            Console.WriteLine("\nAhora los elementos en la Cola son: ");
            foreach(string temp in cola){
                Console.WriteLine(temp);
            }

            Console.WriteLine("\nMientra los elementos en el Array-Cola son: ");
            foreach(string temp in copiaCola){
                Console.WriteLine(temp);
            }

            Console.WriteLine("======== Fin del ejercicio 3========\n");
        } 
    }
}