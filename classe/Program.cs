using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            Console.WriteLine("Digite ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu nome completo");
            string nomeCompleto = Console.ReadLine();

            Pessoa pessoa = new Pessoa();
            pessoa.SetarAnoNascimento(anoNascimento);
            pessoa.SetarNomeCompleto(nomeCompleto);
            pessoa.Exibir();

            Console.WriteLine("fim");
            Console.ReadLine();

        }
    }
}
