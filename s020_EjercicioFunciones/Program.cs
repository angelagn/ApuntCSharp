// See https://aka.ms/new-console-template for more information
using System;
// /*Procedimiento ejercicio
// -personalizar terminal
// -limpiar texto terminalñ
// -logica (programa)
// -introducir num entero pos
// solucuion (procedimiento)
// -par impar*/ 
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
             //Personalizar terminal es darle formato
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            System.Console.WriteLine("Bienvenido");

            int num;
            System.Console.WriteLine("introducir numero");
            num = int.Parse(Console.ReadLine());
            System.Console.WriteLine("\n\n\n" );
            System.Console.WriteLine("Fin del programa");
            Console.ReadKey();

            // void parImpar(int tempnum1){
            //     int x;
            //     x= (tempnum1 % 2);
            //     if( x == 0){
            //         System.Console.WriteLine("Valor par");
            //     }else{
            //         System.Console.WriteLine("Valor impar");
            //     }
                
            // }
        } 
    }
}

