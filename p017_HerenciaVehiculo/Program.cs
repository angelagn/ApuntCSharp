// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            System.Console.WriteLine("Hello World!"); 
            //Crea el objeto
            Vehiculo coche1 = new Vehiculo();

            //Asigna valores al objeto porque no hay constructor
            coche1.matricula = "Se -564";
            coche1.modelo = "Opel Astra 33";
            coche1.potenciaCV = 100;

            /*LLAMAR A METODOS */
                //Crea un metodo que aumenta la potencia
                void AddPotencia(){
                    coche1.potenciaCV += 5;
                }
                //llamar a que se ejecute el metodo addpotencia de esta clase
                AddPotencia();
                //llama al metodo de la clase vehiculo
                coche1.AddPotencia();


            //Obtener datos
            //Modo1
            System.Console.WriteLine(coche1.getMatricula());
            //Modo2
            /*Se crea una nueva variable para realizar acciones de analisis
             de esa nueva variable como un if o switch*/
            string matriculaTemp = coche1.getMatricula();
            System.Console.WriteLine("valor matricula "+ matriculaTemp);

            coche1.showMatriculaModeloPotencia();


            //Objeto tipo taxi
            System.Console.WriteLine("______________________________________");
            Taxi taxi1 = new Taxi();
            taxi1.matricula = "fdr-456";
            taxi1.modelo = "Tesla";
            taxi1.potenciaCV = 120;
            taxi1.numLicencia = 23425;
            taxi1.showMatriculaModeloPotencia();
            System.Console.WriteLine("Licencia " + taxi1.getNumLicencia());

            //Objeto tipo taxi
            System.Console.WriteLine("______________________________________");
            Taxi taxi2 = new Taxi();
            taxi2.matricula = "fdr-445";
            taxi2.modelo = "Citroen";
            taxi2.potenciaCV = 120;
            taxi2.numLicencia = 9876;
            taxi2.showMatriculaModeloPotencia();
            System.Console.WriteLine("Licencia " + taxi1.getNumLicencia());

            //Objeto tipo autobus
            System.Console.WriteLine("______________________________________");
            Autobus autobus1 = new Autobus();
            autobus1.matricula = "fdr-445";
            autobus1.modelo = "Mercedes";
            autobus1.potenciaCV = 120;
            //autobus1.numPlazas = 30;

            autobus1.showMatriculaModeloPotencia();
            //muestra elnumero de plazas asignadas por defecto en el cosntructor
            System.Console.WriteLine("num plazas " + autobus1.getNumPLazas()); 

             //Objeto tipo autobus
            System.Console.WriteLine("______________________________________");
            Autobus autobus2 = new Autobus(10); // se agigna la variable temp del constructor 2
            autobus2.matricula = "sdf-445";
            autobus2.modelo = "Toyota";
            autobus2.potenciaCV = 120;
            //autobus1.numPlazas = 30;

            autobus2.showMatriculaModeloPotencia();
            //muestra elnumero de plazas asignadas por defecto en el cosntructor
            System.Console.WriteLine("num plazas " + autobus2.getNumPLazas()); 


        } 
    }
}
