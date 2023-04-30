using System;
namespace HelloWorld
{
    class Operaciones
    {
        int val1;
        int val2;
        string val3;

        //COnstructor
        public Operaciones(int v1, int v2, string v3)
        {

            val1 = v1;
            val2 = v2;
            val3 = v3;
        }
        //Metodo
        public void ResultadoOperacion()
        {

            switch (val3)
            {
                case "+":
                    System.Console.WriteLine(val1 + val2);
                    break;
                case "-":
                    System.Console.WriteLine(val1 - val2);
                    break;
                case "*":
                    System.Console.WriteLine(val1 * val2);
                    break;
                case "/":
                    System.Console.WriteLine(val1 / val2);
                    break;
                default:
                    break;
            }
        }

    }

}
