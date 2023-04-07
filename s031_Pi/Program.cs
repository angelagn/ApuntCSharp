// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            /*2. Crea un programa en C# para calcular la superficie y el volumen de 
            una esfera, dado su radio.
	        -superficie = 4 * pi * radio al cuadrado
	        -volumen = 4/3 * pi * radio al cubo */

            double superficie = 0;
            double volumen = 0;
            Console.WriteLine("Ingrese el radio: ");
            double radio = Convert.ToInt32(Console.ReadLine());

            superficie = 4 * Math.PI * Math.Sqrt(radio);
            System.Console.WriteLine("La superficie es: " + superficie);
            volumen = 4/3 * Math.PI * Math.Sqrt(radio);
            System.Console.WriteLine("El volumen es: " + volumen);
        } 
    }
}
