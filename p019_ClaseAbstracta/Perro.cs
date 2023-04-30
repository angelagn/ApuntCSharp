using System;
namespace HelloWorld 
{ 
   class Perro : Animal{

    //Crea clase que define método abstracto sobreescribiendo el método abstracto
    public override void animalSound(){

        System.Console.WriteLine("sonido del perro...metodo abstracto");

    }
    public override void animalOjos(){
        
        System.Console.WriteLine("ojos del perro...metodo abstracto");

    }
    public override void animalPatas(){
        
        System.Console.WriteLine("patas del perro...metodo abstracto");

    }

   }
}