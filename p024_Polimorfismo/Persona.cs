using System;
namespace HelloWorld 
{ 
    class Persona 
    { 
        public string nombre;
        public string apellido;
        public string documento;
        public string tipo;

    //Metodo para sobreescribir
        public virtual void Saludar(){
            System.Console.WriteLine("Saludando desde el Padre");
        }
        
    }
}