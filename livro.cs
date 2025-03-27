
using System;

class livro
    {
        // atributos
        public string titulo { get; set; }
        public string autor { get; set; }
        public int paginas { get; set; }

        // método para exibir informações do livro
        public void exibirinformacoes()
        {
            Console.WriteLine($"título: {titulo}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"número de páginas: {paginas}");
        }

    
}



