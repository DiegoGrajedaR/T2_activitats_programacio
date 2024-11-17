using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introdueix un text:");
        string text = Console.ReadLine();

        Console.WriteLine("Vols convertir el text a majúscules o minúscules? 1. majús // 2. minús:");
        int opcio = int.Parse(Console.ReadLine());

        string resultat = ConvertirText(text, opcio );
        Console.WriteLine($"Resultat: {resultat}");
    }

    public static string ConvertirText(string text, int opcio)
    {
        if (opcio == 1)
            return text.ToUpper(); // Converteix a majúscules
        else if (opcio == 2)
            return text.ToLower(); // Converteix a minúscules
        else
            return text; // Retorna el text sense canvis perquè l'opció no es valida
    }
}
