using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE PEDIDOS ONLINE ===");
        Console.WriteLine();

        // PEDIDO 1 - Cliente dos Estados Unidos

        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "Salt Lake City",
            "Utah",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "John Smith", endereco1
        );

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(
            new Produto("Teclado", "P001", 25m, 2)
        );

        pedido1.AdicionarProduto(
            new Produto("Mouse", "P002", 15m, 1)
        );

        pedido1.AdicionarProduto(
            new Produto("Monitor", "P003", 150m, 1)
        );

        // PEDIDO 2 - Cliente do Brasil

        Endereco endereco2 = new Endereco(
            "Rua das Flores, 100",
            "Salvador",
            "Bahia",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "Maria Santos", endereco2
        );

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(
            new Produto("Notebook", "P004", 800m, 1)
        );

        pedido2.AdicionarProduto(
            new Produto("Fone de ouvido", "P005", 30m, 2)
        );

        // Exibir os pedidos

        ExibirPedido(pedido1, 1);
        ExibirPedido(pedido2, 2);
    }

    // Método auxiliar para exibir cada pedido
    static void ExibirPedido(Pedido pedido, int numero)
    {
        Console.WriteLine($"=== PEDIDO {numero} ===");

        Console.WriteLine("\nEtiqueta de embalagem:");
        Console.WriteLine(pedido.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de envio:");
        Console.WriteLine(pedido.ObterEtiquetaEnvio());

        Console.WriteLine(
            $"\nValor total: US$ {pedido.CalcularCustoTotal():F2}"
        );

        Console.WriteLine("--------------------------------");
        Console.WriteLine();
    }
}