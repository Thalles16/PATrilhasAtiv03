using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número inteiro:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número inteiro:");
        int numero3 = int.Parse(Console.ReadLine());

        // Verifica se o primeiro número é menor que o segundo e maior que o terceiro
        if (numero1 < numero2 && numero1 > numero3)
        {
            Console.WriteLine("O primeiro número é menor que o segundo e maior que o terceiro.");
        }
        else
        {
            Console.WriteLine("O primeiro número é menor que o segundo e maior que o terceiro.");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}
