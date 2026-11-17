
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CRIATIVIDADE - Além dos requisitos:
        // 1. Biblioteca com várias escrituras.
        // 2. Seleção aleatória de uma escritura.
        // 3. Ocultação somente de palavras ainda visíveis.

        Random aleatorio = new Random();

        List<Escritura> biblioteca = new List<Escritura>
        {
            new Escritura(
                new Referencia("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito."
            ),

            new Escritura(
                new Referencia("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos e ele endireitará as tuas veredas."
            ),

            new Escritura(
                new Referencia("1 Néfi", 3, 7),
                "Eu irei e cumprirei as ordens do Senhor."
            )
        };

        int indice = aleatorio.Next(biblioteca.Count);
        Escritura escritura = biblioteca[indice];

        while (true)
        {
            Console.Clear();

            Console.WriteLine("=== MEMORIZADOR DE ESCRITURAS ===");
            Console.WriteLine();

            Console.WriteLine(escritura.ObterTextoExibicao());

            if (escritura.EstaTotalmenteOculta())
            {
                Console.WriteLine();
                Console.WriteLine("Parabéns! Todas as palavras foram ocultadas.");
                break;
            }

            Console.WriteLine();
            Console.Write("Pressione Enter para continuar ou digite 'sair': ");

            string resposta = (Console.ReadLine() ?? "").Trim();

            if (resposta.Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }
    }
}
