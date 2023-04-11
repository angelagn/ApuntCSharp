// See https://aka.ms/new-console-template for more information
using System;


namespace HelloWorld 
{ // crea enumeracion con dias de la semana
//imprimir tres valores
    class Hello 
    {  enum DiasSemana{ //FUERA DEL MAIN
        lunes,
        martes,
        miercoles,
        jueves,
        viernes,
        sabado,
        domingo
    }  
        static void Main(string[] args) 
        { 
            Console.WriteLine("Valor: " + DiasSemana.lunes);
            Console.WriteLine("Valor: " + DiasSemana.martes);
            Console.WriteLine("Valor: " + DiasSemana.viernes);
            //Imprimir el indice de los valores
            Console.WriteLine("Valor: " + (int)DiasSemana.lunes);
            Console.WriteLine("Valor: " + (int)DiasSemana.martes);
            Console.WriteLine("Valor: " + (int)DiasSemana.viernes);

           
        } 
    }
}
