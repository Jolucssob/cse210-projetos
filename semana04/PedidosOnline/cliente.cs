public class Cliente
{
    // Atributos privados - Encapsulamento
    private string _nome;
    private Endereco _endereco;

    // Construtor da classe Cliente
    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    // Retorna o nome do cliente
    public string GetNome()
    {
        return _nome;
    }

    // Verifica se o cliente mora nos Estados Unidos
    public bool MoraNosEUA()
    {
        return _endereco.EstaNosEUA();
    }

    // Retorna o endereço completo do cliente
    public string ObterEnderecoCompleto()
    {
        return _endereco.ObterEnderecoCompleto();
    }
    // Retorna o endereço do cliente
    public Endereco GetEndereco()
    {
        return _endereco;
    }
}