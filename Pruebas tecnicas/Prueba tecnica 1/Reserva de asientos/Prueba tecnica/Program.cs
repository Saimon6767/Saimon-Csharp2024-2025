using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrizdeasientos = new char[10, 5]
            {
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
                { 'L', 'L', 'L', 'L', 'L' },
            };

            while (true)
            {



                for (int i = 0; i < matrizdeasientos.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizdeasientos.GetLength(1); j++)
                    {
                        Console.Write(matrizdeasientos[i, j] + " ");
                    }
                    Console.WriteLine(+i);
                }


                Console.WriteLine("elije el asiento");
                string asiento = Console.ReadLine();


                int fila = int.Parse(asiento[0].ToString());
                int columna = int.Parse(asiento[1].ToString());




                if (matrizdeasientos[fila, columna] == 'L')
                {
                    matrizdeasientos[fila, columna] = 'X';
                    Console.WriteLine("se reservo el asiento");
                }





                else if (matrizdeasientos[fila, columna] == 'X')
                {
                    Console.WriteLine("no se pudo reservar pq ta ocupado");
                }






                if (matrizdeasientos[fila, columna] > matrizdeasientos.Length)
                {

                    Console.WriteLine("Hubo una sobreventa y se eligio el asiento ubicado en los dos primeros digitos");

                }


            }




        }
    }
}