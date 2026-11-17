
using System;
using System.Collections.Generic;
using System.Linq;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _aleatorio = new Random();

    // Construtor
    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    // Retorna a escritura completa ou parcialmente oculta
    public string ObterTextoExibicao()
    {
        List<string> texto = new List<string>();

        foreach (Palavra palavra in _palavras)
        {
            texto.Add(palavra.ObterTextoExibicao());
        }

        return _referencia.ObterReferenciaEmTexto()
            + "\n" + string.Join(" ", texto);
    }

    // Oculta somente palavras que ainda estão visíveis
    public void OcultarPalavrasAleatorias(int quantidade)
    {
        List<Palavra> visiveis = _palavras
            .Where(p => !p.EstaOculta())
            .ToList();

        for (int i = 0; i < quantidade && visiveis.Count > 0; i++)
        {
            int indice = _aleatorio.Next(visiveis.Count);

            visiveis[indice].Ocultar();

            visiveis.RemoveAt(indice);
        }
    }

    // Verifica se todas as palavras foram ocultadas
    public bool EstaTotalmenteOculta()
    {
        return _palavras.All(p => p.EstaOculta());
    }
}
