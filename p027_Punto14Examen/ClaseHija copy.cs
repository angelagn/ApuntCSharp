using System;
namespace HelloWorld 
{ 
    class ClaseHija :ClasePadre
    { 
        static void Main(string[] args) 
        { 
            ClaseHija hija1 = new ClaseHija();
            hija1.Cantante = "Michael Jackson";
            hija1.Estilo = "Pop";
            hija1.Anio = 2000;
           
            hija1.ImprimirCantante();
            hija1.ImprimirEstilo();
            hija1.ImprimirAnio();
        } 
    }
}
