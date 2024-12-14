using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        double contador = 0;


        while (contador < 100)
        {
            contador = contador + 1;
            suma = suma + contador;

        }

        


        Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);

    }
}