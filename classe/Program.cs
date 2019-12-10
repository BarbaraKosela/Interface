using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            pessoa.SetarAnoNascimento(anoNascimento);

            Console.WriteLine("Digite seu nome completo");
            string nomeCompleto = Console.ReadLine();
            pessoa.SetarNomeCompleto(nomeCompleto);

            pessoa.Exibir();

            Console.WriteLine("fim");
            Console.ReadLine();

        }
    }
}
