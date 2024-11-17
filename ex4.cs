using System;

public class Program
{   
    public static void Main(string[] args)
    {
        Console.Write("Introdueix un número menor a 100 (positiu): ");
        int numero = int.Parse(Console.ReadLine());

        bool numValid = NumeroPositiuMayor100(numero);


        if (numValid == true)
        {
            Console.WriteLine("El número és positiu i menor que 100.");
        }
        else
        {
            Console.WriteLine("El nombre NO és vàlid.");
        }
    }

    public static bool NumeroPositiuMayor100(int numero)
    {
        return numero > 0 && numero < 100;
    }
}
