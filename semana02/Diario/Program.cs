// CSE 210 - Semana 02 - Projeto Diario
//
// Criatividade e melhorias além dos requisitos:
//
// Implementei o armazenamento dos registros no formato JSON,
// utilizando System.Text.Json, em vez de um arquivo de texto
// com separadores simples.
//
// Essa abordagem permite preservar os campos de cada registro,
// incluindo data, pergunta e resposta, mesmo quando o usuário
// utiliza vírgulas, aspas ou outros caracteres no texto.
//
// O programa também verifica se o arquivo existe antes de
// tentar carregá-lo e apresenta mensagens para orientar
// o usuário durante o salvamento e o carregamento.
using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDeComando gerador = new GeradorDeComando();

        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine("\n=== PROGRAMA DE DIÁRIO ===");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            opcao = (Console.ReadLine() ?? "").Trim();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterComandoAleatorio();

                    Console.WriteLine($"\n{pergunta}");
                    Console.Write("> ");

                    string resposta = Console.ReadLine() ?? "";
                    string data = DateTime.Now.ToShortDateString();

                    Entrada entrada = new Entrada(data, pergunta, resposta);
                    diario.AdicionarEntrada(entrada);
                    break;

                case "2":
                    Console.WriteLine("\n=== EXIBIÇÃO DO DIÁRIO ===");

                    diario.ExibirTodasEntradas();

                    Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Nome do arquivo para salvar: ");
                    string arquivoSalvar = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(arquivoSalvar))
                    {
                        try
                        {
                            diario.Salvar(arquivoSalvar);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao salvar: {ex.Message}");
                        }
                    }
                    break;

                case "4":
                    Console.Write("Nome do arquivo para carregar: ");
                    string arquivoCarregar = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(arquivoCarregar))
                    {
                        try
                        {
                            diario.Carregar(arquivoCarregar);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao carregar: {ex.Message}");
                        }
                    }
                    break;

                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}