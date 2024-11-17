using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix un número per validar si es natural: ");
        int numero = int.Parse(Console.ReadLine());

        bool esNatural = ValidarNumeroNatural(numero);
        if (esNatural == true)
        {
            Console.WriteLine("Número natural");
        }
        else
        {
            Console.WriteLine("Número no natural");
        }
    }

    // Funcio que valida si el número es natural 
    static bool ValidarNumeroNatural(int numero)
    {
        return numero >= 0;
    }
}

