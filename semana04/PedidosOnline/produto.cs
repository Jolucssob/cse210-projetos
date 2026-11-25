public class Produto
{
    // Atributos privados - Encapsulamento
    private string _nome;
    private string _idProduto;
    private decimal _preco;
    private int _quantidade;

    // Construtor da classe Produto
    public Produto(string nome, string idProduto,
                   decimal preco, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    // Retorna o nome do produto
    public string GetNome()
    {
        return _nome;
    }

    // Retorna a identificação do produto
    public string GetIdProduto()
    {
        return _idProduto;
    }

    // Calcula o custo total do produto
    public decimal CalcularCustoTotal()
    {
        return _preco * _quantidade;
    }
}