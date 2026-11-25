using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criar o primeiro vídeo
        Video video1 = new Video(
            "Introdução à programação em C#",
            "Carlos Almeida",
            600
        );

        video1.AdicionarComentario(
            new Comentario("Ana", "Excelente explicação!")
        );

        video1.AdicionarComentario(
            new Comentario("Pedro", "Aprendi muito.")
        );

        video1.AdicionarComentario(
            new Comentario("Mariana", "Ótimo conteúdo!")
        );

        // Criar o segundo vídeo
        Video video2 = new Video(
            "Educação ambiental",
            "Paulo Santos",
            480
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Tema muito importante.")
        );

        video2.AdicionarComentario(
            new Comentario("Julia", "Gostei da apresentação.")
        );

        video2.AdicionarComentario(
            new Comentario("Rafael", "Muito educativo!")
        );

        // Criar o terceiro vídeo
        Video video3 = new Video(
            "Desenvolvimento de software",
            "Marcos Oliveira",
            720
        );

        video3.AdicionarComentario(
            new Comentario("Beatriz", "Muito interessante!")
        );

        video3.AdicionarComentario(
            new Comentario("Daniel", "Excelente conteúdo.")
        );

        video3.AdicionarComentario(
            new Comentario("Fernanda", "Parabéns pelo vídeo!")
        );

        // Criar uma lista de vídeos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Exibir as informações dos vídeos
        Console.Clear();

        Console.WriteLine("=== MONITORAMENTO DE VÍDEOS ===");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            video.ExibirInformacoes();
        }
    }
}