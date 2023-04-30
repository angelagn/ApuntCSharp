using System;
namespace HelloWorld 
{ 
    public class Animal 
    { 
       public virtual string HacerSonido(){ //Prepara a la funcion para ser sobreescrita
        return "Sonido animal";
       }
    }
    public class Perro : Animal{
        
        public override string HacerSonido(){ //Indica que la fincion está sobreescrita
        return "Sonido Perro";
       }
    }
    public class Gato : Animal{
        
        public override string HacerSonido(){
        return "Sonido Gato";
       }

       public void saludar(){
            System.Console.WriteLine("Hola");
       }
    }
}