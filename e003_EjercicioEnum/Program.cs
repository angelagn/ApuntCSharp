// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        enum operaciones{SUMA, RESTA, MULTIPLICACION, DIVISION};
        enum respuesta {SI, NO};
        enum diasSemana {LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO};
        enum meses{Enero = 1, Febrero = 2, Marzo = 3};
        enum boolean {FALSE, TRUE};
        enum playerState {alive, dead, running, fighting};
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("valor: " + operaciones.SUMA); 

            string Temp = operaciones.SUMA.ToString(); //Convierte el valor a texto
            System.Console.WriteLine(meses.Enero); //Imprime el elemento
            System.Console.WriteLine((int)meses.Enero); //Imprime el valor
        } 
    }
}