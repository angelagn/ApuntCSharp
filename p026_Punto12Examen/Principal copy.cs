
/*12. Crea un proyecto C#, con 2 clases, una será la principal y otra la secundaria con 3 variables y 3
métodos o funciones de saludo y/o despedidas. Desde la principal instanciaremos la segunda clase,
asignaremos valores a sus variables accesibles y ejecutaremos sus métodos, guarda el archivo.cs
generado para la entrega junto al examen */
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           Secundaria obj1 = new Secundaria();
           obj1.nombre = "Angela Guzmán";
           obj1.Nombre();
           obj1.Saludo();
           obj1.Despedida();
        } 
    }
}

