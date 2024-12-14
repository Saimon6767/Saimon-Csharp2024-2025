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


        double promedio = suma / 100;


        Console.WriteLine("La suma de los primeros 100 numeros naturales es: " + suma);
        Console.WriteLine("El promedio de los primeros 100 numeros naturales es: " + promedio);
    }
}