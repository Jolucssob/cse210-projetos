using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Diario
{
    private List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada entrada)
    {
        _entradas.Add(entrada);
        Console.WriteLine("Registro adicionado com sucesso!");
    }

    public void ExibirTodasEntradas()
    {
        Console.WriteLine("\n=== REGISTROS DO DIÁRIO ===");

        if (_entradas.Count == 0)
        {
            Console.WriteLine("Nenhum registro encontrado.");
            return;
        }

        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void Salvar(string nomeArquivo)
    {
        string json = JsonSerializer.Serialize(
            _entradas,
            new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            });

        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void Carregar(string nomeArquivo)
    {
        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string json = File.ReadAllText(nomeArquivo);

        List<Entrada>? entradas = JsonSerializer.Deserialize<List<Entrada>>(
            json,
            new JsonSerializerOptions
            {
                IncludeFields = true
            });

        _entradas = entradas ?? new List<Entrada>();

        Console.WriteLine("Diário carregado com sucesso!");
    }
}