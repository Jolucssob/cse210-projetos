public class Comentario
{
    // Atributos privados da classe
    private string _nome;
    private string _texto;

    // Construtor da classe
    public Comentario(string nome, string texto)
    {
        _nome = nome;
        _texto = texto;
    }

    // Retorna o nome da pessoa
    public string ObterNome()
    {
        return _nome;
    }

    // Retorna o texto do comentário
    public string ObterTexto()
    {
        return _texto;
    }
}