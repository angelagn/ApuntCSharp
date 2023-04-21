// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld 
{ 
    class Hello 
    { 
        static void Main(string[] args) 
        { 
            // Lista de enteros con 5 valores
            List<int> list = new List<int>();  
            //Añadir elementos a la lista
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(4);
            list.Add(5);

            //Borrado de  varios elementos
            list.RemoveAll(item => item == 2); //Recorre la lista

            //Imprimir la nueva lista 
            foreach(int num in list){
                System.Console.WriteLine("Value " + num);
            }

            //Preguntar si hay un valor dentro de la lista
            System.Console.WriteLine("Si contiene: " + list.Contains(1)); //Preguntas si la lista tiene el valor 1

            //Analizar el valor
            // bool temp = list.Contains(1){
            //     if(temp == true){
            //         // resto de codigo
            //     }
            // }

            //Preguntas

            System.Console.WriteLine("Si contiene: " + list.Contains(1));
            System.Console.WriteLine("Posicion: " + list.IndexOf(1));

            //Comparar varias listas
            List<int> list2 = new List<int>();

            list2.Add(1);
            list2.Add(2);

            bool result = list2.Equals(list);
            System.Console.WriteLine(result);

            //Encontrar elementos dentro de una lista FIND
            List<String> listCoches = new List<string>() {"BMw", "Citroen", "Seat"}; //Pasar elementos entre llaves


            //Se pueden añadir elementos con add
            listCoches.Add("Twingo");

            foreach(String num in listCoches){
                System.Console.WriteLine("Value " + num);
            }

            System.Console.WriteLine("Coche encontrado: \n");
            System.Console.WriteLine(listCoches.Find(marca => marca == "Citroen")); // crea vaariable temporal marca
            // Si no corresponde, no imprime nada

            //Segundo modo de encontrar objetos
            //EXTRAE ELEMENTOS Y LOS GUARDA EN UNA NUEVA LISTA.
            List<String> listaEncontrar = listCoches.FindAll(elemento => elemento.Contains("w"));
           
             foreach(String num in listaEncontrar){
                System.Console.WriteLine("Valores encontrados " + num);
            }

            //Compara las listas dato a dato
            List<String> primeraLista = new List<string>() {"A","B", "C"};
            List<String> segundaLista = new List<string>() {"b","B", "C"};
            bool isEqual = primeraLista.SequenceEqual(segundaLista);
            System.Console.WriteLine(isEqual);



        } 
    }
}
