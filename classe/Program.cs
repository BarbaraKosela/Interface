using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa;
            bool continuePerguntas = true;
            Console.WriteLine("inicio");
            string nomeCompleto = "";
            int dataNascimento = 0;

            while (continuePerguntas)
            {
                Console.WriteLine("Digite 1 se for mulher | Digite 2 se for homem: | Digite 3 para sair");
                int escolhaHomemMulher = Convert.ToInt32(Console.ReadLine());

                switch (escolhaHomemMulher)
                {
                    case 1:
                        PerguntaNome(nomeCompleto);
                        PerguntasAnoNascimento(dataNascimento);
                        pessoa = new Mulher(nomeCompleto);
                        pessoa.SetarAnoNascimento(dataNascimento);
                        pessoa.Exibir();
                        continuePerguntas = false;
                        break;

                    case 2:
                        PerguntaNome(nomeCompleto);
                        PerguntasAnoNascimento(dataNascimento);
                        pessoa = new Homem(nomeCompleto);
                        pessoa.SetarAnoNascimento(dataNascimento);
                        pessoa.Exibir();
                        continuePerguntas = false;
                        break;

                    case 3:
                        continuePerguntas = false;
                        break;

                    default:
                        continuePerguntas = true;
                        Console.WriteLine("Este comando não é válido");
                        break;
                }
            }
            Console.WriteLine("fim");
            Console.ReadLine();
        }
        static void PerguntaNome(string nomeCompleto)
        {
            Console.WriteLine("Digite seu nome completo: ");
            nomeCompleto = Console.ReadLine();
        }
        static void PerguntasAnoNascimento(int dataNascimento)
        {
            Console.WriteLine("Digite seu ano de nascimento: ");
            dataNascimento = Convert.ToInt32(Console.ReadLine());
        }
    }
}