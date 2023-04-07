// See https://aka.ms/new-console-template for more information
using System;

namespace EjerciciosClase
{

    public class Program
    {
        static void Main(string[] args)
        {
           // Switch se usa cuando hay más de 3 preguntas...
           int day = 2;
           switch(day){
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
    }
}