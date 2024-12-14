using System;

class Program
{
    static void Main(string[] args)
    {
        double sueldoBruto, afp, sfs, isr, sueldoNeto;
        double afpate = 0.0287; 
        double sfsRte = 0.0304; 
        double ISR = 499884.00;
        double t1 = 749822.00;
        double t2 = 1041224.00;

       
        Console.Write("Ingrese el sueldo mensual del empleado: ");
        sueldoBruto = Convert.ToDouble(Console.ReadLine());

        
        afp = sueldoBruto * afpate;
        sfs = sueldoBruto * sfsRte;

        
        double sueldoAnual = sueldoBruto * 12;


        
        isr = 0;

        
        if (sueldoAnual > ISR)
        {
            if (sueldoAnual <= t1)
            {
                isr = (sueldoAnual - ISR) * 0.15;
            }
            else if (sueldoAnual <= t2)
            {
                isr = (sueldoAnual - t1) * 0.20 + 37_491.00;
            }
            else
            {
                isr = (sueldoAnual - t2) * 0.25 + 75_082.00;
            }
        }

        
        sueldoNeto = sueldoBruto - afp - sfs - (isr / 12);

        
        Console.WriteLine("Sueldo bruto " + sueldoBruto);
        Console.WriteLine("Descuento AFP" + afp);
        Console.WriteLine("Descuento SFS " + sfs);

        
        if (isr > 0)
        {
            Console.WriteLine("ISR por meses" + (isr / 12));
        }
        else
        {
            Console.WriteLine("ISR: No Aplica");
        }

        Console.WriteLine("Sueldo Neto Mensual: RD$ " + sueldoNeto);
    }
}
  