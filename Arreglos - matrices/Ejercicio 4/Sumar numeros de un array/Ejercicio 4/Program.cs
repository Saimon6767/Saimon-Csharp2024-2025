using System;


namespace Eje
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros quieres ingresar: ");
            int[] posiciones = new int[Convert.ToInt32(Console.ReadLine())];
            int[] numeros1 = new int[posiciones.Length];

            for (int i = 0; i < posiciones.Length; i++)
            {
                Console.Write("Ingresa el numero: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.Write(numeros1.Sum());
            Console.ReadLine();


            if (numeros1.Sum() >= 100)
            {
                Console.Write("Es mayor o igual a 100");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No es mayor o igual a 100");
                Console.ReadLine();
            }
        }
    }
}