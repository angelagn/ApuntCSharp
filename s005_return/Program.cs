// See https://aka.ms/new-console-template for more information
using System;

namespace Program{


class Ejercicio
{
    // Se auto-ejecuta
    static void Main(string[] args) {

    Console.WriteLine("Hello, World!");
    Console.WriteLine(suma());
     Console.WriteLine(resta());
     Console.WriteLine(saludo());
   
   //Funcion que devuelve un entero
    int suma(){
        int nnumtemoral = 7;
        return nnumtemoral + 3;
    }
    int resta(){
        int nnumtemoral = 7;
        return nnumtemoral -3;
    }
    // Función que devuelve un string
    String saludo(){
        return "Hola";
    }

    }
 }
}