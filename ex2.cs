using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("CALCULAR POTENCIA D'UN NOMBRE");

        Console.Write("Introdueix la base: ");
        float baseNum = float.Parse(Console.ReadLine());

        Console.Write("Introdueix l'exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        float resultat = CalcularPotencia(baseNum, exponent);

        if (exponent > 0)
        {
            Console.WriteLine($"El resultat de {baseNum}^{exponent} es: {resultat}");
        }
        else
        {
            exponent = -exponent;
            Console.WriteLine($"El resultat de {baseNum}^{exponent} es: 1/({baseNum}^{exponent})");
        }
    }

    public static float CalcularPotencia(float baseNum, int exponent)
    {
        float resultat = 1;

        // Bucle per calcular la potència
        for (int i = 0; i < exponent; i++)
        {
            resultat = resultat * baseNum;
        }
        
        return resultat;
    }
}

