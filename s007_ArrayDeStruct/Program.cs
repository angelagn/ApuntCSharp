// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{


    class Ejercicio
    {
       struct tipoPersona{
        public string nombre;
        public char inicial;
        public int edad;
        public float nota;
       }
    public static void Main(string[] args)
    {
        tipoPersona[] personas = new tipoPersona[100];
        
        personas[0].nombre = "Juan";
        personas[0].inicial = 'J'; //¿? por que las comillas simples, string a char
        personas[0].edad = 20;    
        personas[0].nota = 7.5f;
        Console.WriteLine("La edad de {0} es {1}", personas[0].nombre,
                            personas[0].edad);
        
        personas[1].nombre = "Pedro";
        personas[1].edad = 23;
        Console.WriteLine("La edad de {0} es {1}", personas[1].nombre,
                            personas[1].edad);


    }
    }
}