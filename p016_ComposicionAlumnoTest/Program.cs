// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            AlumnoTest alumno1 = new AlumnoTest();
        

            alumno1.InicializarAlumno();
            alumno1.ImprimirAlumno();
            alumno1.EsMayorEdadAlumno();

        } 
    }
}
