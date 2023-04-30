// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            Perro obj1 = new Perro();
            obj1.nameDog = "Randy";
            obj1.age =12;
            obj1.Ladrar(); 
            System.Console.WriteLine(obj1.nameDog);
            System.Console.WriteLine(obj1.age);
            System.Console.WriteLine(obj1.Ladrar());

            PerroPadre obj2 = new PerroPadre();
            obj2.nameDog = "Jacki";
            obj2.age =12;
            obj1.Ladrar(); 
            System.Console.WriteLine(obj1.nameDog);
            System.Console.WriteLine(obj1.age);
            System.Console.WriteLine(obj1.Ladrar());
            
            chihuahua obj3 = new chihuahua();
            obj3.nameDog = "Obi";
            System.Console.WriteLine(obj3.Ladrar());
            bulldog obj4 = new bulldog();
            obj4.nameDog = "Jack";
            System.Console.WriteLine(obj4.Ladrar());

            
            //Lista de objetos herencia polimorfismo
            List<PerroPadre> animales = new List<PerroPadre>();
            animales.Add(new chihuahua());
            animales.Add(new bulldog());

            //Recorrer la lista
            foreach(PerroPadre x in animales){ //Puedo acceder a métodos y variables
                System.Console.WriteLine(x.Ladrar());
                System.Console.WriteLine(x.nameDog);
                
            }
        } 
    }
}
