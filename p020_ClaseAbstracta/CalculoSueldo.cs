using System;
namespace HelloWorld 
{ 
    class CalculoSueldo{
       public int[] miArray; //Declaro array de enteros
        public int index;
        public CalculoSueldo(){
            
            System.Console.WriteLine("ingrerse numero");
            index = Convert.ToInt32(Console.ReadLine());
            miArray = new int[index];

            for(int i = 0; i< index; i++){
                System.Console.WriteLine("Introduce el valor a almacenar");
                miArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            


        }
        public void ShowArrayElements(){
            System.Console.WriteLine("Mostrando elementos del array");
            for(int i = 0; i < miArray.Length; i++){
                System.Console.WriteLine($"El valor de la posicion {i} es: {miArray[i]}");
            }

        }
    }
}