// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // // Función que devuelve valor, tiene la pralabra return
            int Dardoble(int Temp){
                return(Temp*2);
            }
            Dardoble(2);

            Hello obj1 = new Hello(); //Instancia una clase "copia clase"
            obj1.DardobleMETODO(5);
            Console.WriteLine(obj1.DardobleMETODO(2));
            
        } 
        public int DardobleMETODO(int temp2){ // Método, está fuera del main
            return(temp2 * 3);
        }
    }
}
