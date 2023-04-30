using System;
namespace HelloWorld 
{ 
    class Triangulo 
    { 
        public void CalcularAreaFigura(){
            throw new NotImplementedException();
        }

        public void CalcularAreaFigura(int b, int altura){
            System.Console.WriteLine("El area del triangulo es: " + ((b * altura)/2));
        }
         
    }
}