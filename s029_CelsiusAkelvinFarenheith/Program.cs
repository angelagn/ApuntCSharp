// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
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
