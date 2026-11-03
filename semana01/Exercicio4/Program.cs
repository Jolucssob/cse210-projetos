
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        int soma = 0;

        foreach (int valor in numeros)
        {
            soma += valor;
        }

        Console.WriteLine($"A soma é: {soma}");

        if (numeros.Count > 0)
        {
            double media = (double)soma / numeros.Count;
            Console.WriteLine($"A média é: {media}");
        }

        if (numeros.Count > 0)
        {
            int maior = numeros[0];

            foreach (int valor in numeros)
            {
                if (valor > maior)
                {
                    maior = valor;
                }
            }

            Console.WriteLine($"O maior número é: {maior}");
        }

        int? menorPositivo = null;

        foreach (int valor in numeros)
        {
            if (valor > 0)
            {
                if (menorPositivo == null || valor < menorPositivo)
                {
                    menorPositivo = valor;
                }
            }
        }

        if (menorPositivo != null)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }
        else
        {
            Console.WriteLine("Não há números positivos na lista.");
        }

        numeros.Sort();

        Console.WriteLine("A lista reordenada é:");

        foreach (int valor in numeros)
        {
            Console.WriteLine(valor);
        }

    }
}
