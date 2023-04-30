using System;
using System.Collections;
namespace HelloWorld 
{ 
    class Test 
    { 
        public void TestHastable(){
            System.Console.WriteLine("testeando hastable");
            //PRIMERA MANERA DE CREAR EL OBJETO
            Hashtable numberNames = new Hashtable();

            
            numberNames.Add(1, "uno");
            numberNames.Add(2, "dos");
            numberNames.Add(3, "tres");
            numberNames.Add(4, "cuatro");
            numberNames.Add(5, "cicnco");

            //Borrar el elemento 5
            numberNames.Remove(5);

            //Imrime LIFO
            foreach(DictionaryEntry x in numberNames){
                System.Console.WriteLine("Llave:  {0}, value {1}", x.Key, x.Value);
            }

            //SEGUNDA MANERA DE CREAR EL OBJETO
            //Crea nuevo objeto de clase hashtable
            
            var cities = new Hashtable(){
                {"España", "Alicante, Madrid, Barcelona"},
                {"USA", "Chicago, new York, Washinton"},
                {"India", "New delhi, Pune"}
            };

            //Borra un elemento
            cities.Remove("USA");
            //Actualiza un valor
            cities["India"] = "Mumbai";

            

             //Imprime
            foreach(DictionaryEntry x in cities){
                System.Console.WriteLine("Llave:  {0}, value {1}", x.Key, x.Value);
            }
            if(! cities.ContainsKey("Francia"))
                cities["Francia"] = "Paris";

            //Cuenta el numero de elementos
            System.Console.WriteLine(cities.Count);

            /*Hay que procurar respetar las llaves porque es el id del
            elemento, generalmente se cambia es el valor */

        }
    }
}