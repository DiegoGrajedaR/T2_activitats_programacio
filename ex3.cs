using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix un número para validar si es negatiu: ");
        int numero = int.Parse(Console.ReadLine());

        bool esNegatiu = ValidarNumeroNegatiu(numero);

        if (esNegatiu == true)
        {
            Console.WriteLine("El número es negatiu.");

        }
        else
        {
            Console.WriteLine("El número no es negatiu.");
        }
    }
    public static bool ValidarNumeroNegatiu(int numero)
    {
        return numero < 0;
    }
}
