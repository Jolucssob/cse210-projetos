using System;

public class Entrada
{
    public Entrada()
    {
        _data = "";
        _pergunta = "";
        _resposta = "";
    }
    public string _data;
    public string _pergunta;
    public string _resposta;

    public Entrada(string data, string pergunta, string resposta)
    {
        _data = data;
        _pergunta = pergunta;
        _resposta = resposta;
    }

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_resposta}");
        Console.WriteLine("-----------------------------");
    }
}