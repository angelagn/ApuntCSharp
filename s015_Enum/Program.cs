// See https://aka.ms/new-console-template for more informat
using System;

namespace Program
{

    class Ejercicio

    
    {
    static int varStatic;
        // Se auto-ejecuta
    enum EstacionAnio{
        primavera,
        verano,
        otono,
        invierno
    }    
    public static void Main(string[] args)
        {
            Console.WriteLine("Valor: "+ EstacionAnio.otono);
            //Preguntar por los elementos de las enumeraciones
            Console.WriteLine("Estacion Primavera: "+ EstacionAnio.verano.ToString().Equals("otono"));
            Console.WriteLine("VAlor numérico: "+ ((int)EstacionAnio.primavera));
            Console.WriteLine("VAlor numérico: "+ ((int)EstacionAnio.verano));
            Console.WriteLine("VAlor numérico: "+ ((int)EstacionAnio.otono));
            Console.WriteLine("VAlor numérico: "+ ((int)EstacionAnio.invierno));

            int indiceValor = (int)EstacionAnio.primavera;

        }
    }
}
