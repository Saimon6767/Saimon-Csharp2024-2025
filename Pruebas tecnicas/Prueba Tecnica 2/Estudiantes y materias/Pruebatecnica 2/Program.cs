using System;

class Program
{

    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");

            Console.WriteLine("Edad:" + Edad);
        }
    }

    public class Estudiante2
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public void MostrarInfo2()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("Edad:" + Edad);
        }
    }


    public class Asignatura2
    {

        public string Nombreasignatura2 { get; set; }
        public double Calificacion1 { get; set; }

        public double Calificacion2 { get; set; }

        public void MostrarInfoasignatura11()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura2}");
            Console.WriteLine("Calificacion:" + Calificacion1);



        }

        public void MostrarInfoasignatura22()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura2}");
            Console.WriteLine("Calificacion:" + Calificacion2);



        }

    }


    public class Asignatura3
    {

        public string Nombreasignatura3 { get; set; }
        public double Calificacion1 { get; set; }

        public double Calificacion2 { get; set; }

        public void MostrarInfoasignatura33()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura3}");
            Console.WriteLine("Calificacion:" + Calificacion1);



        }

        public void MostrarInfoasignatura333()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura3}");

            Console.WriteLine("Calificacion:" + Calificacion2);



        }

    }


    public class Asignatura1
    {
        public string Nombreasignatura1 { get; set; }
        public double Calificacion1 { get; set; }

        public double Calificacion2 { get; set; }


        public void MostrarInfoasignatura1()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura1}");

            Console.WriteLine("Calificacion:" + Calificacion1);



        }

        public void MostrarInfoasignatura2()
        {
            Console.WriteLine($"Nombre de la asignatura: {Nombreasignatura1}");
            Console.WriteLine("Calificacion:" + Calificacion2);



        }



    }










    static void Main()
    {

        Estudiante estudiante = new Estudiante();
        Estudiante2 estudiante2 = new Estudiante2();

        Console.WriteLine("mete el nombre del estudiante ");
        estudiante.Nombre = Console.ReadLine();


        Console.WriteLine("ahora la edad del estudiante");
        estudiante.Edad = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ahora datos del segundo estudiante ");

        Console.WriteLine("mete el nombre del estudiante 2 ");
        estudiante2.Nombre = Console.ReadLine();



        Console.WriteLine("ahora la edad del estudiante 2");
        estudiante2.Edad = Convert.ToInt16(Console.ReadLine());





        Asignatura1 asignatura1 = new Asignatura1();
        Asignatura2 asignatura2 = new Asignatura2();
        Asignatura3 asignatura3 = new Asignatura3();

        Console.WriteLine("Nombre de la asignatura");
        asignatura1.Nombreasignatura1 = Console.ReadLine();
        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante.Nombre} en {asignatura1.Nombreasignatura1}");
        asignatura1.Calificacion1 = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante2.Nombre} en {asignatura1.Nombreasignatura1}");
        asignatura1.Calificacion2 = Double.Parse(Console.ReadLine());



        Console.WriteLine("Crea la segunda asignatura");
        asignatura2.Nombreasignatura2 = Console.ReadLine();
        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante.Nombre} en {asignatura2.Nombreasignatura2}");
        asignatura2.Calificacion1 = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante2.Nombre} en {asignatura2.Nombreasignatura2}");
        asignatura2.Calificacion2 = Double.Parse(Console.ReadLine());


        Console.WriteLine("Crea la tercera asignatura");
        asignatura3.Nombreasignatura3 = Console.ReadLine();
        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante.Nombre} en {asignatura3.Nombreasignatura3}");
        asignatura3.Calificacion1 = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Ingresa las notas que obtuvo el estudiante {estudiante2.Nombre} en {asignatura3.Nombreasignatura3}");
        asignatura3.Calificacion2 = Double.Parse(Console.ReadLine());



        Console.WriteLine($"Ahora se mostraran las calificaciones");


        Console.WriteLine($"");
        asignatura1.MostrarInfoasignatura1();
        asignatura2.MostrarInfoasignatura11();
        asignatura3.MostrarInfoasignatura33();
        Console.WriteLine($"Nombre del estudiante:  {estudiante.Nombre} ");
        Console.WriteLine($"Edad del estudiante:  {estudiante.Edad} ");
        double calif1 = asignatura1.Calificacion1 + asignatura2.Calificacion1 + asignatura3.Calificacion1 / 3;
        Console.WriteLine($"promedio de calificaciones es: " + calif1);
        Console.WriteLine($"");
        Console.WriteLine($"");





        Console.WriteLine($"Ahora el otro estudiante");
        Console.WriteLine($"");
        asignatura1.MostrarInfoasignatura2();
        asignatura2.MostrarInfoasignatura22();
        asignatura3.MostrarInfoasignatura333();
        Console.WriteLine($"Nombre del estudiante:  {estudiante2.Nombre} ");
        Console.WriteLine($"Edad del estudiante:  {estudiante2.Edad} ");
        double calif2 = asignatura1.Calificacion2 + asignatura2.Calificacion2 + asignatura3.Calificacion2 / 3;
        Console.WriteLine($"ppromedio de calificaciones es: " + calif2);
    }
}