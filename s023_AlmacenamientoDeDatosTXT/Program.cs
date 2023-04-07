// See https://aka.ms/new-console-template for more information
using System;
using System.IO; // In Out para trabajar con ficheros .txt


namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           
        /* 0 - 1 bits => bytes
        -StreamWriter => para escribir en los .txt
        -StreamReades => para leer en .txt
        -File dentro de System.IO (crear, copiar, eliminar, mover, abrir)
        */

        // CREAR ARCHIVO DE TEXTO 
        // //Sin posibilidad de añadir contenido, se come la info anterior
        // StreamWriter Escritura1 = File.CreateText("ejemplo.txt");
        // //Escribir en el archivo
        // Escritura1.WriteLine("Estoy escibiendo en el arhivo");
        // Escritura1.WriteLine("Estoy escibiendo en el arhivo2");
        // // Siempre cerrar el archivo para guardar el contenido
        // Escritura1.Close();

        // //CREAR Y EDITAR AÑADIENDO CONTENIDO EN ARCHIVO TEXTO
        // string nombre =  "";
        // byte nota = 0;

        // //Pedir datos al usuario
        // System.Console.WriteLine("Introducir nombre: ");
        // nombre = Console.ReadLine();
        // System.Console.WriteLine("Introducr nota del aumno: ");
        // //Parseo de tipos string a byte
        // nota = byte.Parse(Console.ReadLine());
        // //Crear archivo .txt
        // StreamWriter Escritura2 = File.AppendText("ejemplo.txt");

        // Escritura2.WriteLine("Nota " + nota + ": " + nombre);
        // Escritura2.Close(); // Siempre cerrar

        //LEER EL ARCHIVO
        StreamReader lectura1 = File.OpenText("ejemplo.txt");

        try {
            string linea = lectura1.ReadLine();
            while(linea != null){ // si el archivo es diferente a vacio
                System.Console.WriteLine(linea);
                linea = lectura1.ReadLine(); //Pasa a la siguiente línea
            }
            lectura1.Close();
        }catch{
            lectura1.Close();
        }

        } 
    }
}
