using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine($"Aquest programa fara un canvi de valor entre el dos números que introdueixis a continuació -->");

        Console.WriteLine("Introdueix valor númeric 1:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdueix valor númeric 2:");
        int valor2 = int.Parse(Console.ReadLine());


        ActualitzarValors(ref valor1, ref valor2);
        Console.WriteLine("");
        Console.WriteLine($"RESPOSTA: Ara el valor númeric 1 = {valor1} i valor númeric 2 = {valor2}");
    }

    public static void ActualitzarValors(ref int valor1, ref int valor2)
    {
        int canvi = valor1;
        valor1 = valor2;
        valor2 = canvi;
    }
}