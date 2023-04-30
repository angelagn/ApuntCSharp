// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        /*Ejercicio3:

	- Crea una lista de string para almacenar los valores de una tabla de 5 elementos ( Modelos de Ordenadores )
	- Añade los elementos de la tabla dentro de la lista
	- Recorre imprimiendo los valores de la lista almacenados */

        static void Main(string[] args) 
        { 

            /*Crea una lista de string para almacenar los valores de una tabla de 5 elementos (Modelos de Ordenadores)*/
            
            List<string> list = new List<string>();  

            //Añadir elementos a la lista
            list.Add("Acer");
            list.Add("Apple");
            list.Add("Toshiba");
            list.Add("Asus");
            list.Add("Lenovo");
            

	        // - Recorre imprimiendo los valores de la lista almacenados */
            foreach(string num in list){
                System.Console.WriteLine("Marca " + num);
            }
        } 
    }
}