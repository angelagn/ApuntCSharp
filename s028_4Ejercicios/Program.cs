// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            /*1. Crea un programa en C# que pregunte al usuario en la primera linea 
            ¿Cómo te llamas? y guarde el nombre en la variable x.
             El programa debe responder en la segunda linea con Encantado de conocerte, x. */

            // Console.WriteLine("Como te llamas?: ");
            // String x = Console.ReadLine();
            // System.Console.WriteLine("Encantado de conocerte " + x);

            /*2. Crea un programa en C# para calcular la superficie y el volumen de 
            una esfera, dado su radio.
	        -superficie = 4 * pi * radio al cuadrado
	        -volumen = 4/3 * pi * radio al cubo */

            // double superficie = 0;
            // double volumen = 0;
            // Console.WriteLine("Ingrese el radio: ");
            // double radio = Convert.ToInt32(Console.ReadLine());

            // superficie = 4 * Math.PI * Math.Sqrt(radio);
            // System.Console.WriteLine("La superficie es: " + superficie);
            // volumen = 4/3 * Math.PI * Math.Sqrt(radio);
            // System.Console.WriteLine("El volumen es: " + volumen);

            /*3. Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés. */

            // Console.WriteLine("Ingrese tres letras: ");
            // String letras = Console.ReadLine();
            // string invertida = "";
            // foreach(char letra in letras){
            //     invertida = letra + invertida;
            // }
            // System.Console.WriteLine(invertida);

            /* 4. La escala Celsius es centígrada, 100 divisiones separan el 
            punto de congelación del punto de ebullición del agua. En la escala 
            Fahrenheit de los anglosajones, estos dos puntos están separados por 
            180 grados. La escala de Kelvin es una escala absoluta utilizada en 
            ciencias. Cree un programa en C# para convertir de grados centígrados 
            a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados
             centígrados para convertirlos usando las siguientes tablas de 
             conversión:

	            kelvin = celsius + 273
	            fahrenheit = celsius x 18/10 + 32 */

            Console.WriteLine("Ingrese grados centigrados: ");
            double celcius = Convert.ToInt32(Console.ReadLine());

            double kelvin = celcius + 273.15;
            double fahrenheit = (celcius * 9/5) + 32;

            System.Console.WriteLine("Conversion a escala Kelvin: " + kelvin);
            System.Console.WriteLine("Conversion a farenheit: " + fahrenheit);

        
        } 
    }
}
