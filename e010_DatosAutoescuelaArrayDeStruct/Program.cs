// See https://aka.ms/new-console-template for more information
using System;

/*3. Tenemos una academia de conducir y tenemos que almacenar los siguientes datos de los alumnos
a través de una estructura
- Nombre
- Apellidos
- Edad
- Estudios ( ESO, FP1, FP2, Universitarios ) => Enum
Solicitar dichos datos al usuario e ir almacenándolos en una estructura de un sólo registro */
namespace HelloWorld 
{ 
    class Hello 
    { 
        enum estudiosEnum{ 
        ESO,
        FP1,
        FP2,
        Universitarios
        }

        struct alumnoAutoescuela{
            public string nombre;
            public string apellidos;
            public int edad;
            public string nivelEstudios;

            //Para acceder a un dato, alumnoAutoescuela.nombre;
            //Hay que acceder primero a la estructura y luego a la propiedad
        }
        static void Main(string[] args) 
        { 
            Console.Clear();
            System.Console.WriteLine("Ejercicio 3\n\n");

              //Crea un array de  struct
            alumnoAutoescuela[] arrayDeStruct = new alumnoAutoescuela[2];

            //Guardar el nombre en la variable de la estructura
            Console.WriteLine("Introducir Nombre: ");
            arrayDeStruct[0].nombre = Console.ReadLine();
            //System.Console.WriteLine("Dato nombre: " + arrayDeStruct[0].nombre);

            Console.WriteLine("Introducir Apellido: ");
            arrayDeStruct[0].apellidos = Console.ReadLine();   

            Console.WriteLine("Introducir edad: ");
            arrayDeStruct[0].edad = int.Parse(Console.ReadLine());  // Parsea la edad    
          
            Console.WriteLine("Introducir EStudios (E(eso), F1(FP1), F2,(FP2) U(Universitario): ");
            arrayDeStruct[0].nivelEstudios = Console.ReadLine();   


            //Switch que controla la entrada de datos, y asigna los datos al enum
            switch(arrayDeStruct[0].nivelEstudios){
                case "E":
                    arrayDeStruct[0].nivelEstudios = estudiosEnum.ESO.ToString();
                    break;
                case "F1":
                    arrayDeStruct[0].nivelEstudios = estudiosEnum.FP1.ToString();
                    break;
                case "F2":
                    arrayDeStruct[0].nivelEstudios = estudiosEnum.FP2.ToString();
                    break;
                case "U":
                    arrayDeStruct[0].nivelEstudios = estudiosEnum.Universitarios.ToString();
                    break;
                default:
                    arrayDeStruct[0].nivelEstudios = "Llamar a alumno";
                break;


            }

            arrayDeStruct[1].nombre = "Miguel";
            arrayDeStruct[1].apellidos = "Gomez";
            arrayDeStruct[1].edad = 34;
            arrayDeStruct[1].nivelEstudios = "Administrador";

            //Bloque lógico
            for(int i= 0; i< 2; i++){
            System.Console.WriteLine("Imprime Ejercicio 3\n");
            System.Console.WriteLine("Nombre: " + arrayDeStruct[i].nombre);
            System.Console.WriteLine("Apellido: " + arrayDeStruct[i].apellidos);
            System.Console.WriteLine("Edad: " + arrayDeStruct[i].edad);
            System.Console.WriteLine("Estudios: " + arrayDeStruct[i].nivelEstudios);
            }
        } 
    }
}
