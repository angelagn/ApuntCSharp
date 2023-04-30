using System;
namespace HelloWorld 
{ 
    public class Sobrecarga{

        //Declaro variables
        int num = 5;
        int num2 = 3;


        //Sobrecarga de métodos
        public void Metodo(){
            System.Console.WriteLine("Método sin parametros");

        }
        public int Metodo(int num){
            System.Console.WriteLine("metodo devuelve entero: " + num);
            return num;
        }

        public int Metodo(int num, int num2){
            int suma = num + num2;
            System.Console.WriteLine("La suma es: "+ suma);
            return suma;
        }
    }
    
}