// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // //Sacar un numero aleatorio
            // Random r1 = new Random(); //Objeto de tipo random que crea numero aleatorio
            // int num1 = r1.Next(1, 99);
            // System.Console.WriteLine(num1);

            // Loteria Automatica
            // Random r2 = new Random(); // el segundo ramdom lleva parentesis porque se refiere a la clase polomorfismo
            // for(int i = 0; i < 6; i++){
            //    // System.Console.WriteLine(r2.Next(1, 49));
            //     System.Console.WriteLine(r2.NextDouble());
            // }

            //calcula numero maximo
            int a = 10;
            int b = 5;
            if (a > b)
                System.Console.WriteLine("mayor es: " + a);

            //Funcion Max
            System.Console.WriteLine(Math.Max(10,5));
            //Funcion Min
            System.Console.WriteLine(Math.Min(10,5));
            //Raiz cuadrada
            System.Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(4));
            //Valor absoluto
            System.Console.WriteLine("Valor ABS: " + Math.Abs(-4.7));
            //Redondear numero
            System.Console.WriteLine("Redondear: " + Math.Round(9.99));
            System.Console.WriteLine("Redondear: " + Math.Round(4.51)); // 4.5 redonea a 4, 4.51 redondea a 5
            System.Console.WriteLine("Redondear: " + Math.Round(4.51, 3));

        } 
    }
}
