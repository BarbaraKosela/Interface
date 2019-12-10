using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            Console.WriteLine("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine().Trim();

            while(!nomeCompleto.Contains(" "))
            {
                Console.WriteLine("Digite nome completo novamente!");
                nomeCompleto = Console.ReadLine();
            }
            Mulher mulher = new Mulher(nomeCompleto);
            mulher.MudarNome(nomeCompleto);
            mulher.Exibir(nomeCompleto);
            /*
            Console.WriteLine("Digite nome novamente para mudar: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sobrenome novamente para mudar: ");
            sobrenome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, sobrenome);
            pessoa.Exibir();

            pessoa.MudarNome(nome, sobrenome);
            pessoa.ExibirNome();*/
            Console.WriteLine("fim");
            Console.ReadLine();

        }
    }
}
