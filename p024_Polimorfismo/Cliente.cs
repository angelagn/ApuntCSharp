using System;
namespace HelloWorld 
{ 
    /*Cliente heredea de persona e implementa "hereda" la interfaz alunmo */
    class Cliente : Persona, IAlumno 
    { 
        //Variables
        public string categoria;
        public int codigo;

        //constructor - se autoejecuta
        /*La palabra base hace que se ejecute el metodo de 
        la clase padre */
        public Cliente(){
            base.Saludar(); //Ejecuta el método del padre
        }

        public void GenerarCodigo(){
            System.Console.WriteLine("Generando codigo");   
        }
        //Metodo sobreescrito
        public override void Saludar(){
            System.Console.WriteLine("Saludando desde el Hijo");
        }
        //Implementa interface
        public void NotaAlumno(){
            System.Console.WriteLine("Imprime nota alumno");
        }
    }
}