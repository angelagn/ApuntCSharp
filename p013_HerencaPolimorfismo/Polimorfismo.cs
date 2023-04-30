using System;
namespace HelloWorld 
{ 
    class Perro 
    { 
        //Herencia, nos permite el polimorfismo
        public string nameDog;
        public int age;

        public string Ladrar(){
            return "Perro Ladrando";
        }
    }

    public class PerroPadre{
        public string nameDog = "Jacki";
        public int age;

        public virtual string Ladrar(){ //virtual modifica metodos
            return "Perro Ladrando";
        }
    }

    public class chihuahua : PerroPadre{
        public override string Ladrar(){ //override sobreescribe el metodo
            System.Console.WriteLine("valor padre "+ base.Ladrar());
            System.Console.WriteLine("Nombre padre " + base.nameDog);
            return "Perro chihuahua Ladrando";
            //return base.Ladrar(); //Base indica que se vaya al padre y ejecute ladrar
        }
    }
    public class bulldog : PerroPadre{
        public override string Ladrar(){ //override sobreescribe el metodo
            return "Perro bulldog Ladrando";
            
        }
    }
}