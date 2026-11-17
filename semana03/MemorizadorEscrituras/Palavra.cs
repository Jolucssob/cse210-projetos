
public class Palavra
{
    private string _texto;
    private bool _oculta;

    // Construtor
    public Palavra(string texto)
    {
        _texto = texto;
        _oculta = false;
    }

    // Oculta a palavra
    public void Ocultar()
    {
        _oculta = true;
    }

    // Verifica se a palavra está oculta
    public bool EstaOculta()
    {
        return _oculta;
    }

    // Retorna a palavra ou sublinhados
    public string ObterTextoExibicao()
    {
        if (_oculta)
        {
            return new string('_', _texto.Length);
        }

        return _texto;
    }
}
