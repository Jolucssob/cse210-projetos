
public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculoInicial;
    private int _versiculoFinal;

    // Construtor para um único versículo
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculo;
        _versiculoFinal = versiculo;
    }

    // Construtor para um intervalo de versículos
    public Referencia(string livro, int capitulo,
                      int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculoInicial;
        _versiculoFinal = versiculoFinal;
    }

    public string ObterReferenciaEmTexto()
    {
        if (_versiculoInicial == _versiculoFinal)
        {
            return $"{_livro} {_capitulo}:{_versiculoInicial}";
        }

        return $"{_livro} {_capitulo}:{_versiculoInicial}-{_versiculoFinal}";
    }
}
