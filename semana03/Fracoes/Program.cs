
using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste dos três construtores
        Fracao fracao1 = new Fracao();
        Fracao fracao2 = new Fracao(5);
        Fracao fracao3 = new Fracao(3, 4);
        Fracao fracao4 = new Fracao(1, 3);

        // Exibir as frações e seus valores decimais
        Console.WriteLine(fracao1.ObterFracaoEmTexto());
        Console.WriteLine(fracao1.ObterFracaoEmDecimal());

        Console.WriteLine(fracao2.ObterFracaoEmTexto());
        Console.WriteLine(fracao2.ObterFracaoEmDecimal());

        Console.WriteLine(fracao3.ObterFracaoEmTexto());
        Console.WriteLine(fracao3.ObterFracaoEmDecimal());

        Console.WriteLine(fracao4.ObterFracaoEmTexto());
        Console.WriteLine(fracao4.ObterFracaoEmDecimal());

        // Teste do encapsulamento com Get e Set
        Fracao teste = new Fracao(2, 5);

        Console.WriteLine("\nTeste de Encapsulamento:");

        Console.WriteLine(teste.ObterFracaoEmTexto());

        teste.SetNumerador(3);
        teste.SetDenominador(4);

        Console.WriteLine(teste.ObterFracaoEmTexto());
        Console.WriteLine(teste.GetNumerador());
        Console.WriteLine(teste.GetDenominador());
    }
}
