using System;
namespace HelloWorld 
{ 
    class Encapsulacion
 
    { 
        public class primera{
            public int valor1;
            protected int valor2;

        }
        public class segunda{
            public int valor1;
            private int valor2;

        }
         public class segundaSolucion{
            public int valor1;
            private int valor2;

            /*Constructor de la clase, accede a partes encapsuladas, 
            siempre tiene el mismo nombre de la clase, nunca poner 
            pababra void ni tipo de dato*/
            public segundaSolucion(int valor){ //Actualiza el valor de la variable Set
                valor2 = valor; 
            }
            public int getValor2(){ // get
                return valor2;
            }

        }
        public class tercera : primera{
            public int valor5;
            private int valor6;

        }
        public void Saludo(){
            System.Console.WriteLine("Hola");
        }
        private void Saludop(){
            System.Console.WriteLine("Hola");
        }

    }
}

