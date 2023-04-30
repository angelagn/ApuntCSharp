// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Operaciones suma = new Operaciones(10,5, "+");
            suma.ResultadoOperacion();
            Operaciones resta = new Operaciones(10,7, "-");
            resta.ResultadoOperacion();
            Operaciones mult = new Operaciones(10,7, "*");
            mult.ResultadoOperacion();
            Operaciones div = new Operaciones(10,7, "/");
            div.ResultadoOperacion();


        } 
    }
}
