
using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            int numeroMagico = geradorAleatorio.Next(1, 101);
            int tentativas = 0;

            Console.WriteLine("Novo jogo iniciado!");

            Console.Write("Qual é o seu palpite? ");
            int palpite = int.Parse(Console.ReadLine()!);
            tentativas++;

            while (palpite != numeroMagico)
            {
                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else
                {
                    Console.WriteLine("Mais baixo");
                }

                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine()!);
                tentativas++;
            }

            Console.WriteLine("Você adivinhou!");
            Console.WriteLine($"Você precisou de {tentativas} tentativas.");

            Console.Write("Deseja jogar novamente? (sim/não) ");
            jogarNovamente = Console.ReadLine()!.Trim().ToLower();
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}
