using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    // Atributos privados - Encapsulamento
    private List<Produto> _produtos;
    private Cliente _cliente;

    // Construtor
    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    // Adiciona um produto ao pedido
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    // Calcula o custo do envio
    private decimal CalcularFrete()
    {
        if (_cliente.MoraNosEUA())
        {
            return 5m;
        }

        return 35m;
    }

    // Calcula o valor total do pedido
    public decimal CalcularCustoTotal()
    {
        decimal total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        return total + CalcularFrete();
    }

    // Gera a etiqueta de embalagem
    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();

        foreach (Produto produto in _produtos)
        {
            etiqueta.AppendLine(
                $"{produto.GetNome()} - ID: {produto.GetIdProduto()}"
            );
        }

        return etiqueta.ToString();
    }

    // Gera a etiqueta de envio
    public string ObterEtiquetaEnvio()
    {
        return _cliente.GetNome() + "\n"
            + _cliente.GetEndereco().ObterEnderecoCompleto();
    }
}