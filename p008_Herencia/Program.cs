// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
           Personal obj1 = new Personal(1, "Angela", "Guzman"); //El constructor me obliga a pasar parametros
            
            Profesor profe1 = new Profesor(1, "Miguel", "Yllanes"); //Cuando se ponene los valores en los parentesis se está haciendo set
            System.Console.WriteLine("valor: " + profe1._Nombre); // Desde la variable original
            System.Console.WriteLine("valor: " + profe1._Nombre); // Desde el metodo get
            System.Console.WriteLine("valor: " + profe1.Apellidos2); // Desde el metodo get
            
        } 

    }

    public class Personal{
        
        //variables estaticas, porque están debajo de la clase

        private int _id;
        public string _Nombre;
        private string _Apellidos;

        //Mrtodos get y set 
        //Rompe la encapsulación, permite cambiar el valor y acceder al valor

        //Cambiar u obtener el valor de la variable con set y get
        public int Id{
            get {return _id;} // devuelve variable privada id
            set { _id = value;}
        }
        public string Nombre2{
            get { return _Nombre;}
            set { _Nombre = value;}
        }

        public string Apellidos2{
            get { return _Apellidos;}
            set { _Apellidos = value;}
        }

        //Constructor
         public Personal(int pId, string pNombre, string pApellidos ){
            _id = pId;
            _Nombre = pNombre;
            _Apellidos = pApellidos;

         }


    }
    //Herencia
    class Profesor : Personal{

        public int nueva;
        //La palabra base indica lo que hereda del padre, hace que agarre las variables del padre
        public Profesor(int pId, string pNombre, string pApellidos) 
            : base(pId, pNombre, pApellidos){
            
            nueva = 7; // la variable nueva se utiliza dentro de profesor
        }
    }
}