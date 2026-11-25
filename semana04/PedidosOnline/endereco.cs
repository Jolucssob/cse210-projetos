using System;

public class Endereco
{
    // Atributos privados - Encapsulamento
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    // Construtor
    public Endereco(string rua, string cidade,
                    string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    // Verifica se o endereço está nos Estados Unidos
    public bool EstaNosEUA()
    {
        string pais = _pais.Trim().ToUpperInvariant();

        return pais == "EUA"
            || pais == "USA"
            || pais == "ESTADOS UNIDOS"
            || pais == "UNITED STATES";
    }

    // Retorna o endereço completo
    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}