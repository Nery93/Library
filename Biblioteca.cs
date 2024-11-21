using System;
using System.Collections.Generic;

namespace Library
{
    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>(); // Lista de livros

        public Biblioteca() // Construtor
        {
            livros.Add(new Livro(1, "C# 10 Programação Funcional", "José Roberto")); // Adicionando livros
            livros.Add(new Livro(2, "Python 3 Programação Funcional", "João Pedro")); // Adicionando livros
            livros.Add(new Livro(3, "C++ Programação Funcional", "Paulo"));
            livros.Add(new Livro(4, "Javascript Programação Funcional", "Souza"));
        }

        public void ExibirMenu() // Método
        {
            Console.WriteLine("\nMenu:"); // Exibindo menu
            Console.WriteLine("1. Emprestar Livro");
            Console.WriteLine("2. Devolver Livro");
            Console.WriteLine("3. Buscar Livros");
            Console.WriteLine("4. Exibir Detalhes");
            Console.WriteLine("5. Exibir Todos os Livros");
            Console.WriteLine("6. Sair");
        }

        public void ExecutarOpcao() // Método
        {
            int opcao = int.Parse(Console.ReadLine()); // Lê a opção do usuário

            switch (opcao) // Verificação
            {
                case 1:
                    EmprestarLivro();
                    break;
                case 2:
                    DevolverLivros();
                    break;
                case 3:
                    BuscarLivros();
                    break;
                case 4:
                    ExibirDetalhes();
                    break;
                case 5:
                    ExibirLivros();
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void EmprestarLivro() // Método
        {
            Console.Write("Digite o ID do livro que deseja emprestar: "); // Pede para o usuário
            int id = int.Parse(Console.ReadLine()); // Lê o ID do livro
            Livro livro = livros.Find(x => x.Id == id); // Pesquisa o livro
            if (livro != null) // Verificação
            {
                livro.EmprestarLivro();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void DevolverLivros() // Método
        {
            Console.Write("Digite o ID do livro que deseja devolver: "); // Pede para o usuário
            int id = int.Parse(Console.ReadLine()); // Lê o ID do livro
            Livro livro = livros.Find(x => x.Id == id); // Pesquisa o livro
            if (livro != null) //
            {
                livro.DevolverLivro();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void BuscarLivros() // Método
        {
            Console.Write("Digite o título do livro que deseja buscar: ");
            string titulo = Console.ReadLine();
            Livro livro = livros.Find(x => x.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)); // Pesquisa o livro
            if (livro != null)
            {
                livro.ExibirDetalhes();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void ExibirDetalhes() // Método
        {
            Console.Write("Digite o ID do livro que deseja exibir: ");
            int id = int.Parse(Console.ReadLine());
            Livro livro = livros.Find(x => x.Id == id); // Pesquisa o livro
            if (livro != null)
            {
                livro.ExibirDetalhes();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void ExibirLivros() // Método
        {
            Console.WriteLine("\nLista de livros na biblioteca:");
            foreach (Livro livro in livros)
            {
                livro.ExibirDetalhes();
                Console.WriteLine();
            }
        }
    }
}
