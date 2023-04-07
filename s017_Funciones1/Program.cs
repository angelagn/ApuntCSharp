// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        {   
            //FUNCION  Sumar tres numeros
            // int  sumar3Num(int num1, int num2, int num3){
            //     return num1+num2+num3;
            // } 

            // int result= sumar3Num(3,3,3);
            // System.Console.WriteLine("Resultado: " + result); 

             // FUNCION  Sumar n  numeros
            // int  sumarNNum(params int[] notas){ // crea un array de enteros 
            //     int suma = 0;
            //     foreach(int nota in notas){
            //         suma = suma + nota;
            //     }
            //     return suma;
            // }
            // Console.WriteLine("Suma total: " + sumarNNum(2,3,4));

            //FUNCION suma notas y saca la media
            int mediaNotas(int num1, int num2, int num3){
                return((num1 + num2 + num3)/ 3);
            }
            Console.WriteLine("Resultado: " + mediaNotas(5,7,8));

            //FUNCION OTRA MANERA suma notas y saca la media
            int mediaNotas2(params int[] notas){
                int suma = 0; 
                foreach(int x in notas){
                    suma = suma + x;
                }
                int result = suma / notas.Length; // Length devuelve el tamaño del array , el numero de veces que se hace el fore each
                return result;

            }
            
            Console.WriteLine("Resultado: " + mediaNotas2(5,7,8));
            Console.WriteLine("Resultado: " + mediaNotas2(10,7,0));
        } 
    }
}
