// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{


    class Ejercicio
    {
        struct tipoCancion{
    public string artista;
    public string titulo;
    public int duracion;
    public int tamañoFichero;
}
        static void Main(string[] args)
        {
            tipoCancion[] personas = new tipoCancion[100];

            Console.WriteLine("Introducir nombre de artista: ");
            String nombreArtista = Console.ReadLine();
            Console.WriteLine("Introducir nombre de la canción:  ");
            String nombreCancion = Console.ReadLine();
            

            personas[0].artista = nombreArtista;
            personas[0].titulo = nombreCancion; //¿? por que las comillas simples, string a char
            personas[0].duracion = 20;    
            personas[0].tamañoFichero = 74;
            Console.WriteLine("El artista es {0}, y la canción es {1}", personas[0].artista,
                                personas[0].titulo);


        }
    }
}