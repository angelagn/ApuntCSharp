using System;
namespace HelloWorld 
{ 
    class TablaMultiplicar 
    { 
      public int number;
    //COnstructores
    //Polimorfismo, el metodo tiene el mismo nobre pero toma formas diferentes
      public TablaMultiplicar(){
        number = 5;
      }  

      public TablaMultiplicar(int var){
        number = var;
      }
    //Metodos
      public void MostrarTabla(){
        for (int i = 0; i <= 10; i++){
            System.Console.WriteLine(i + " x " + number + " = "+ (i*number));
        }

      }

      public void showInfo(){
        String valstr1 = "a";
        String valstr2 = "b";
        System.Console.WriteLine("valueA: "+ valstr1 + ", valueB: "+ valstr2);
      }

      public void showInfo2(string a, string b){ //valor por defecto si no se ingresa la segunda variable
        String valstr1 = a;
        String valstr2 = b;
        System.Console.WriteLine("valueA: "+ valstr1 + ", valueB: "+ valstr2);
      }
       public void showInfo3(string a, string b = "Cadiz"){ //valor por defecto si no se ingresa la segunda variable
        String valstr1 = a;
        String valstr2 = b;
        System.Console.WriteLine("valueA: "+ valstr1 + ", valueB: "+ valstr2);
      }
       public void showInfo4(string a){ //valor por defecto si no se ingresa la segunda variable
        String valstr1 = a;
        String valstr2 = "Cadiz";
        System.Console.WriteLine("valueA: "+ valstr1 + ", valueB: "+ valstr2);
      }
    }
}