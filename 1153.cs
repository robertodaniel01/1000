using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor inteiro N: ");
        int n = int.Parse(Console.ReadLine());

        long fatorial = 1; 

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i; 
        }

        Console.WriteLine($"O fatorial de {n} é: {fatorial}");
    }
}
