using System;
namespace Examen_M2
{
    class Ejercicio1
    {
        public static double notaAlumno;
        public static string Aborrar = "Historia";
        public void solucion1()
        {
            Console.Clear();
            System.Console.WriteLine("\nEjecutando ejercicio numero 1\n");
            

            List<string> listaAsignaturas = new List<String>();

            listaAsignaturas.Add("Matemáticas");
            listaAsignaturas.Add("Física");
            listaAsignaturas.Add("Química");
            listaAsignaturas.Add("Historia");
            listaAsignaturas.Add("Lengua");

            int asigSusperadas;

            System.Console.WriteLine("Las asignaturas del curso son las siguientes: ");
            listaAsignaturas.ForEach(marca => System.Console.WriteLine(marca));

            do
            {
                System.Console.WriteLine("Por favor, indique el número de asignaturas que ha superado (número de 0 a 5): ");
                asigSusperadas = int.Parse(Console.ReadLine());

            } while (asigSusperadas > 5);

            string asignatura;

            if (asigSusperadas == 5)
            {
                System.Console.WriteLine("Enhorabuena, has pasado de curso! :-)");                
            }
            else
            {
                for (int i = 1; i <= asigSusperadas; i++)
                {
                    System.Console.WriteLine("Qué asignaturas del curso has superado? Por favor, intruduce el nombre de la asignatura {0}: ", i);
                    asignatura = Console.ReadLine();
                    listaAsignaturas.Remove(asignatura);
                }

                System.Console.WriteLine("\nLas asignaturas que el alumno tiene que recuperar son: \n");
                listaAsignaturas.ForEach(obj => Console.WriteLine(obj));
            }           

        }
    }
}

