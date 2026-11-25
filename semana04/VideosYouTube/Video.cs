using System;
using System.Collections.Generic;

public class Video
{
    // Atributos privados do vídeo
    private string _titulo;
    private string _autor;
    private int _duracao;

    // Lista de comentários do vídeo
    private List<Comentario> _comentarios;

    // Construtor da classe
    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    // Adiciona um comentário à lista
    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    // Retorna a quantidade de comentários
    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    // Exibe as informações do vídeo
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");

        Console.WriteLine(
            $"Quantidade de comentários: {ObterQuantidadeComentarios()}"
        );

        Console.WriteLine("Comentários:");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine(
                $"- {comentario.ObterNome()}: {comentario.ObterTexto()}"
            );
        }

        Console.WriteLine("----------------------------------------");
    }
}