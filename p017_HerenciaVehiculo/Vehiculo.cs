using System;
namespace HelloWorld 
{ 
  class Vehiculo{
    //Declarar variables
    public string matricula;
    public string modelo;
    public int potenciaCV;

    //Constructor 
    /*Esta clase no tiene cosntructor */
    // metodos get
    public string getMatricula(){
    return matricula;
    }
    public void setMatricula(string tempMat){
        matricula = tempMat;
    }
     public string getModelo(){
    return modelo;
    }
     public void setModelo(string tempMod){
        modelo = tempMod;
    }
     public int getPotenciaCV(){
    return potenciaCV;
    }
    public void setPotenciaCV (int tempPot){
        potenciaCV = tempPot;
    }
    //  
    
    //Metodo que muestra todos los valores
   
    public void showMatriculaModeloPotencia(){
        System.Console.WriteLine("Matricula: " + matricula);
        System.Console.WriteLine("Modelo: " + modelo);
        System.Console.WriteLine("Potencia: " + potenciaCV);
    }
    //Metodo añade potencia
    public void AddPotencia(){
        potenciaCV += 5;
    }
     //Metodo remueve potencia
    public void RemovePotencia(){
        potenciaCV -= 5;
    }

  }

 
}