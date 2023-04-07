// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    
   //TIPO DE DATO STRUCT
    struct tipoAlumno{ //
        public string nombre;
        public int edad;
        public double nota;
        public string notaFinal;
        public char sexo;   // H,M, ?

    }
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           tipoAlumno  persona; /* cada vez que llame a un tipo alumno, 
           tengo cuatro propuiedades que son las variables del objeto*/
           persona.nombre = "Angela";
           persona.edad = 48;
           persona.nota = 9.5;
           persona.sexo = 'M';
            //FORMAS DE IMPRIMIR
           System.Console.WriteLine("La edad {0} ", persona.edad); //Usar los indices de las variables
           System.Console.WriteLine("La edad: " + persona.edad);
           System.Console.WriteLine($"Empleado: {persona.nombre}, edad: {persona.edad}");

        } 
    }
}
