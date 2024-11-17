using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix un número per calcular el seu valor absolut: ");
        double numero = double.Parse(Console.ReadLine());

        double valorAbsolut = CalcularValorAbsolut(numero);
        Console.WriteLine($"El valor absolut del número introduit és: {valorAbsolut}");
        
    }

    public static double CalcularValorAbsolut(double numero)
    {
        if (numero >= 0)
        {
            numero = numero - 0;
        }
        else
        {
            numero = -(numero) - 0;
        }

        return numero;
    }
}