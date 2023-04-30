using System;
namespace HelloWorld 
{ 
    class Hello 
    { 

        public static string nombreAlumno;
        private static int edadAlumno = 20;
        protected static double notaAlumno = 0.00;

        static void Main(string[] args) 
        { 
            AsignarNombre();
            ImprimirValores();
        } 

        // Metodos fuera del MAIN siempre
        public static void AsignarNombre(){
            nombreAlumno = "Miguel";
        }

        public static void ImprimirValores(){
            Console.WriteLine("Nombre: " + nombreAlumno);
            Console.WriteLine("Edad: " + edadAlumno);
        }



    }
}