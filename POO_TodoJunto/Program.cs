using System;
namespace Examen_M2
{ 
    class Examen 
    { 
        static void Main(string[] args) 
        { 
            
            Console.WriteLine("Que ejercicio quiere resolver? 1, 2, 3, 4 o 5");
            
            int numEje = Convert.ToInt32(Console.ReadLine());            

            
            switch(numEje){
                case 1:
                    Ejercicio1 obj1 = new Ejercicio1();
                    obj1.solucion1();
                    break;
                case 2:
                    Ejercicio2 obj2 = new Ejercicio2();
                    obj2.solucion2();
                    break; 
                case 3:
                    Ejercicio3 obj3 = new Ejercicio3();
                    obj3.solucion3();
                    break;
                case 4:
                    Ejercicio4 obj4 = new Ejercicio4();
                    obj4.solucion4();
                    break;
                case 5:
                    Ejercicio5 obj5 = new Ejercicio5();
                    obj5.solucion5();
                    break;
                default:
                    Console.WriteLine("El ejercicio seleccionado no existe");
                    break;
            } 
        }
    }
}