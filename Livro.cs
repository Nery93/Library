using System;

namespace Library
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; set; }

        public Livro(int id, string titulo, string autor, bool disponivel = true)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Disponivel = disponivel;
        }

        public void EmprestarLivro()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"{Titulo} emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está emprestado.");
            }
        }

        public void DevolverLivro()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine($"{Titulo} devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está disponível.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}
