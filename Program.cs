using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            bool sair = false;

            while (!sair)
            {
                biblioteca.ExibirMenu();
                biblioteca.ExecutarOpcao();
                Console.WriteLine("Digite 6 para sair do programa.");
                string opcao = Console.ReadLine();
                if (opcao == "6")
                {
                    sair = true;
                }
            }
        }
    }
}
