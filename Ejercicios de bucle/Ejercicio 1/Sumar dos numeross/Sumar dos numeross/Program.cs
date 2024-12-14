using System;
using System.Collections.Generic;
using System.Text;

namespace Sumar_dos_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {



                int numeroingresado, numeroprimero, resultado;

                numeroprimero = Convert.ToInt32(Console.ReadLine());

                numeroingresado = Convert.ToInt32(Console.ReadLine());

                resultado = numeroprimero + numeroingresado;



                while (numeroingresado > 0)
                {

                    resultado = numeroprimero + numeroingresado;

                    Console.WriteLine("el total es " + resultado);
                    numeroprimero = Convert.ToInt32(Console.ReadLine());
                    numeroingresado = Convert.ToInt32(Console.ReadLine());



                }


                Console.WriteLine("has salido del programa");






            }
        }
    }
