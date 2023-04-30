using System;
namespace HelloWorld 
{ 
   class Autobus : Vehiculo{
        public int numPlazas;
        
        //CSobrecarga de constructores de autobus, inicializa las variables por defecto
        //Constructor 1
        public Autobus(){
            numPlazas = 50;
        }
        //Constructor 2
        public Autobus(int tempPLaza){
            numPlazas = tempPLaza;
        }
        //Metodo get
        public int getNumPLazas(){
            return numPlazas;
        }

        public void setNumPLazas(int tempNum){
        numPlazas = tempNum;
        }
   }
}