// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           int[] array1 = {1, 3, 5, 7, 9}; 
           System.Console.WriteLine("indice 0: " + array1[0]);
           array1[0] = 5;
           System.Console.WriteLine("indice 0: " + array1[0]);

            //Procedimiento por parametro y el valor se manda por referencia
           Change(ref array1);
            //PASAR EL ARRAY A FUNCIÓN Y HACER CAMBIOS
           void Change(ref int[] Temparray1){ //Obtiene el objeto array1
                Temparray1[0] = 1923;
                System.Console.WriteLine("Ultimo valor en esa posicion: " + Temparray1[0]);
           }
        } 
    }
}
