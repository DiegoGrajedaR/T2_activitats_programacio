using System;

public class Program
{
    static void Main(string[] args)
    {
        int intentsRestants = 3;
        bool validat = false;
        Console.WriteLine("Introdueix un nombre natural, disposes de 3 intents:");

        while (intentsRestants > 0 && !validat)
        {
            int numero = int.Parse(Console.ReadLine());
            bool numeroValid = EsNumeroNatural(numero);

            if (numeroValid == true)
            {
                Console.WriteLine("El número introduit es vàlid");
            }

            else
            {
                intentsRestants = intentsRestants - 1;
                Console.WriteLine($"El valor no és vàlid, intents restants: {intentsRestants}");

            }

            // Si s'esgoten els intents, informem a l'usuari
            if (intentsRestants == 0)
        {
             Console.WriteLine("Has esgotat tots els intents. El programa ha finalitzat.");
        }
        }
    }


    public static bool EsNumeroNatural(int numero)
    {
        return numero > 0;
    }
}
