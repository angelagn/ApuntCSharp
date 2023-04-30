using System;
namespace HelloWorld 
{ 
    //Clase abstarct, por lo menos debe tener un metodo no definido
    abstract class Animal{

        string nombr = "Randy";
        int edad;

        //Metodo de siempre
        public void animalSound2(){
            System.Console.WriteLine("Sonido animal metodo normal");
        }
        //Método abstracto
        public abstract void animalSound(); //Hay que usar punto y coma (;) y no lleva llaves
        public abstract void animalOjos();
        public abstract void animalPatas();


        
    }

    
}