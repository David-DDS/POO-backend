
internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo de Livro
        livro meuLivro = new livro
        {
            titulo = "O Senhor dos Anéis",
            autor = "J.R.R. Tolkien",
            paginas = 1216
        };
        Console.WriteLine("Informações do Livro:");
        meuLivro.exibirinformacoes();

        // Exemplo de Aluno
        Aluno aluno1 = new Aluno
        {
            Nome = "Lucas Silva",
            Idade = 21,
            NotaFinal = 8.5
        };
        Aluno aluno2 = new Aluno
        {
            Nome = "Ana Costa",
            Idade = 22,
            NotaFinal = 9.2
        };
        Console.WriteLine("Informações dos Alunos:");
        aluno1.ExibirInformacoes();
        aluno2.ExibirInformacoes();

        // Exemplo de Produto
        Produto meuProduto = new Produto
        {
            Nome = "Laptop",
            Preco = 3500.75,
            QuantidadeEmEstoque = 10
        };
        Console.WriteLine("Informações do Produto Antes da Alteração:");
        meuProduto.ExibirInformacoes();

        // Alterando valores
        meuProduto.Nome = "Smartphone";
        meuProduto.Preco = 2500.50;
        meuProduto.QuantidadeEmEstoque = 5;
        Console.WriteLine("Informações do Produto Depois da Alteração:");
        meuProduto.ExibirInformacoes();
    }
}