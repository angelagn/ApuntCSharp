using System;
namespace HelloWorld 
{ 
    public class AlumnoTest{ 
        //crea objeto rueda de la clase Rueda
        public Alumno alumno = new Alumno();

        public void InicializarAlumno(){
            alumno.Inicializar();
        }
        public void ImprimirAlumno(){
            alumno.imprimir();
        }
        public void EsMayorEdadAlumno(){
            alumno.esMayorEdad();
        }

        
    }

   
     public class Alumno{
        // Variables 
        private string _nombre;
        private int _edad;

        // Método para inicializar las variables _nombre y _edad
        public void  Inicializar(){
            Console.WriteLine("Introducir nombre: ");
            _nombre = Console.ReadLine();
            Console.WriteLine("Introducir edad ");
            _edad = Convert.ToInt32(Console.ReadLine());
           
        }
       // Método para imprimir los valores de _nombre y _edad
        public void imprimir(){
            Console.WriteLine("Nombre: " + _nombre);
            Console.WriteLine("Edad: " + _edad);
        }
        // Método para comprobar si el alumno es mayor de edad
        public void esMayorEdad(){
            if(_edad >= 18){
                Console.WriteLine("El alumno es mayor de edad");
            } else {
                Console.WriteLine("El alumno es menor de edad");
            }
        }
    }
}