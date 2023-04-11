// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{  /*2. Crearemos una aplicación C# sin usar funciones o procedimientos que intente solicitar por
teclado los siguientes datos de un trabajador
- Nombre
- Apellidos
- Edad ( Numero Entero, convierte si hace falta lo que recibes del teclado )
- EstadoCivil, podrá teclear ( S,C,D,V )
Analizaremos el valor introducido y sustituiremos las abreviaturas por un valor pre-cargado en un
enum a la variable EstadoCivil */
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Introducir Apellidos: ");
            String apellidos = Console.ReadLine();
            Console.WriteLine("Introducir edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Introducir estado civil (S, C, D, V): ");
            String estadoCivil = Console.ReadLine();
            imprimirdatos();

            int devolveredad(){
                if (edad > 18)
                {
                    System.Console.WriteLine("Mayor de edad");
                }
                else
                {
                    System.Console.WriteLine("Menor de edad");
                }
                return edad;
            }


            switch (estadoCivil)
            {
                case "S":
                    System.Console.WriteLine("Soltero/a");
                    break;
                case "C":
                    System.Console.WriteLine("Casado/a");
                    break;
                case "D":
                    System.Console.WriteLine("Divorciado/a");
                    break;
                case "V":
                    System.Console.WriteLine("Viudo/a");
                    break;
            }
            //return estadoCivil;

            void imprimirdatos()
            {
                System.Console.WriteLine("Nombre: " + nombre);
                System.Console.WriteLine("Apellidos: " + apellidos);
                System.Console.WriteLine("Edad: " + devolveredad());
                System.Console.WriteLine("Estado Civil: " + estadoCivil);
            }
        }
    }
}
