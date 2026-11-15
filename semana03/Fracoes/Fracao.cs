public class Fracao
{
    private int _numerador;
    private int _denominador;

    // Construtor sem parâmetros: 1/1
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com um parâmetro: numerador/1
    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    // Construtor com dois parâmetros
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;

        if (denominador == 0)
        {
            throw new ArgumentException(
                "O denominador não pode ser zero."
            );
        }

        _denominador = denominador;
    }
    // Retorna o numerador
    public int GetNumerador()
    {
        return _numerador;
    }

    // Altera o numerador
    public void SetNumerador(int numerador)
    {
        _numerador = numerador;
    }

    // Retorna o denominador
    public int GetDenominador()
    {
        return _denominador;
    }

    // Altera o denominador
    public void SetDenominador(int denominador)
    {
        if (denominador != 0)
        {
            _denominador = denominador;
        }
    }
    // Retorna a fração em formato de texto
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna o valor decimal da fração
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}