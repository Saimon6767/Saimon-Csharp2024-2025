using System;


namespace Ejerciciodealmacen
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dispositivos = { "Televisores", "Laptops", "Telefonos" };
            string[] almacenes = { "Almacen", "Almacen", "Almacen" };

            int[,] inventario = new int[dispositivos.Length, almacenes.Length];

            inventario[0, 0] = 10;
            inventario[0, 2] = 12;
            inventario[1, 0] = 20;
            inventario[1, 1] = 7;
            inventario[1, 2] = 15;
            inventario[2, 0] = 25;
            inventario[2, 1] = 30;
            inventario[2, 2] = 18;

           
            Console.WriteLine("| Dispositivo | Almacen | Almacen | Almacen |");
         
            for (int i = 0; i < dispositivos.Length; i++)
            {
                Console.Write($"| " + dispositivos[i].PadRight(12) + "| ");
                for (int j = 0; j < almacenes.Length; j++)
                {
                    Console.Write(inventario[i, j].ToString().PadRight(8) + "| ");
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("");

            for (int j = 0; j < almacenes.Length; j++)
            {
                int totalPorAlmacen = 0;

                for (int i = 0; i < dispositivos.Length; i++)
                {
                    totalPorAlmacen += inventario[i, j];
                }

                Console.WriteLine($"Total en almacen: {totalPorAlmacen}");
            }

            Console.WriteLine("");

            for (int j = 0; j < almacenes.Length; j++)
            {
                int maxCantidad = int.MinValue;
                int minCantidad = int.MaxValue;
                string dispositivoMax = "";
                string dispositivoMin = "";

                for (int i = 0; i < dispositivos.Length; i++)
                {
                    if (inventario[i, j] > maxCantidad)
                    {
                        maxCantidad = inventario[i, j]; dispositivoMax = dispositivos[i];
                    }

                    if (inventario[i, j] < minCantidad)
                    {
                        minCantidad = inventario[i, j]; dispositivoMin = dispositivos[i];
                    }
                }
                Console.WriteLine("En almacen: ");
                Console.WriteLine(" Mayor cantidad: " + dispositivoMax + " (" + maxCantidad + ")");
                Console.WriteLine(" Menor cantidad: " + dispositivoMin + " (" + minCantidad + ")");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}