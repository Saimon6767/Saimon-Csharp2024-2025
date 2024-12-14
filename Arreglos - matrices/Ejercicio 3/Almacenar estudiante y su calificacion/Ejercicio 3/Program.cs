using System;


namespace Ej
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el nombre del estudiante: ");
            string[] estudiante = {Console.ReadLine()};

            Console.Write("Introduce la calificacion del estudiante: ");
            int[] calificaciones = {Convert.ToInt32(Console.ReadLine())};

            Estudiante(estudiante, calificaciones);

        }

        static void Estudiante(string[] estudiante, int[] calificaciones)
        {
            foreach(string estudianteName in estudiante)
            {
                Console.Write($"El nombre del estudiante es: {estudianteName}");
                Console.ReadLine();
            }

            foreach(int calificacionesE in calificaciones)
            {
                Console.Write($"La calificacion del estudiante es: {calificacionesE}");
                Console.ReadLine();
            }
        }
    }
}