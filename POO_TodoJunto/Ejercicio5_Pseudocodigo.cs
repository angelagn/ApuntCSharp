
using System;

namespace Examen_M2

{
    class Ejercicio5
    {
        public void solucion5()
        {
            Console.Clear();
            Console.WriteLine("Ejecutando ejercicio numero 5\n");

            Console.WriteLine("Numeros primos del 1 al 50");
            //Crear variables enteras numero y n
            int numero, n;
            //Crear variable booleana bend  
            bool bend;
            //Creamos una nueva lista
            //List<int> lista = new List<int>();
            //Asignar el valor de 50 a la variable número     
            numero = 50;
            //Recorrer desde 1 la variable número
            for (int x = 1; x <= numero; x++)
            {
                //Asignamos 2 a la variable n
                n = 2;
                //Asignaremos true a la variable bend
                bend = true;

                //Bucle mientras que bend = true y n menos que x
                while (bend && n < x)
                {
                    //Preguntar si el resto de dividir x por n da cero
                    if (x % n == 0)
                    {
                        //En tal caso bend será false
                        bend = false;
                    }
                    else
                    {
                        //Caso contrario
                        n = n + 1;
                        //Preguntar por el estado de la variable bend

                    }

                }
                if (bend)
                {
                   Console.Write( x + ", "); 
                    //lista.Add(x);  
                }
               
            }
            //  foreach(int i in lista){
            //         System.Console.WriteLine("valor: " + i);
            //     }
            //enter para terminar el programa
            Console.ReadLine();
        }
    }
}
