

    class Aluno
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double NotaFinal { get; set; }

        // Método para exibir informações do aluno
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Nota Final: {NotaFinal:F2}");
            Console.WriteLine();
        }
    }

   