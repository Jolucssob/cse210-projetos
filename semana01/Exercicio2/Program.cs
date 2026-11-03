using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota? ");
        string entrada = Console.ReadLine();
        int nota = int.Parse(entrada);
        string letra = "";
        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }
        int ultimoDigito = nota % 10;
        string sinal = "";
        if (ultimoDigito >= 7 && letra != "A" && letra != "F")
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3 && letra != "F")
        {
            sinal = "-";
        }

        Console.WriteLine($"Sua nota conceitual é {letra}{sinal}."); if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso.");
        }
        else
        {
            Console.WriteLine("Continue estudando! Você poderá melhorar na próxima vez.");
        }
    }
}
