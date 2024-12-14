using System;

class Program
{
    static void Main(string[] args)
    {


        double num1;
        double num2;
        

        Console.Write("Ingrese un primer nuzsmero entero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un segundo numero entero: ");
        num2 = Convert.ToInt32(Console.ReadLine());



        if (num1 > num2)
        {
            Console.WriteLine("El numero mayor es " + num1);
        }

        else if (num1 < num2)
        {
            Console.WriteLine("El numero mayor es " + num2);
        }

        else
        {

            Console.Write(" son iguales");
        }








    }
}
