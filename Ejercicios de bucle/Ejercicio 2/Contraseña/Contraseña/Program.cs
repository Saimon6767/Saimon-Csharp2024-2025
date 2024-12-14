using System;

class Program
{
    static void Main()
    {
        int contrasena = 2024, intentosmaximos = 3, vecesintentadas = 0, contrasenapuesta;










        while (vecesintentadas < intentosmaximos)
        {
            Console.Write("Ingresa la contraseña");


            contrasenapuesta = Convert.ToInt32(Console.ReadLine());





            if (contrasenapuesta == contrasena)
            {
                Console.WriteLine("contrasena correcta");
                break;
            }
            else
            {
                Console.WriteLine("contrasena incorrecta intenta denuevo");
                vecesintentadas = vecesintentadas + 1;
            }
        }


        if (vecesintentadas == intentosmaximos) { Console.WriteLine("haz alcanzado el maximo de intentos"); }
    }
}