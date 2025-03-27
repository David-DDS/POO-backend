

class Produto
{
    // Atributos
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    // Método para calcular o total
    public double CalcularTotal()
    {
        return QuantidadeEmEstoque * Preco;
    }

    // Método para exibir as informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco:F2}");
        Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
    }
}


