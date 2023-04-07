// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // //Array
            int[] array1 = {1, 3, 5, 7, 9};
            // //Imprime la posicion del array
            // System.Console.WriteLine(array1[2]); 
            // //Imprime todo el array
            // for(int i = 0; i<=4; i++){
            //     System.Console.WriteLine(array1[i]); 
            // }
            int tempIndex = array1.Length;
            System.Console.WriteLine(tempIndex);
            //CAMBIAR TODOS LOS VALORES DEL ARRAY
             for(int i = 0; i< tempIndex; i++){
                System.Console.WriteLine(array1[i] = 9); 
            }
            //Imprime luego de cambiar
            //  for(int i = 0; i < tempIndex; i++){
            //     System.Console.WriteLine(array1[i]); 
            // }
        } 
    }
}
