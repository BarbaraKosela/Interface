using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa;
            string nomeFornecido;
            int anoNascimentoFornecido;
            bool continuePerguntas = true;

            Console.WriteLine("inicio");

            while (continuePerguntas)
            {
                Console.WriteLine("Digite 1 se for mulher | Digite 2 se for homem: | Digite 3 para sair");
                int escolhaHomemMulher = Convert.ToInt32(Console.ReadLine());

                switch (escolhaHomemMulher)
                {
                    case 1:
                        nomeFornecido = PerguntaNome();
                        anoNascimentoFornecido = PerguntasAnoNascimento();
                        
                        pessoa = new Mulher(nomeFornecido);
                        pessoa.SetarAnoNascimento(anoNascimentoFornecido);
                        pessoa.Exibir();
                        
                        break;

                    case 2:
                        nomeFornecido = PerguntaNome();
                        anoNascimentoFornecido = PerguntasAnoNascimento();
                        pessoa = new Homem(nomeFornecido);
                        pessoa.SetarAnoNascimento(anoNascimentoFornecido);
                        pessoa.Exibir();
                        break;

                    case 3:
                        continuePerguntas = false;
                        break;

                    default:
                        Console.WriteLine("Este comando não é válido");
                        break;
                }
            }
            Console.WriteLine("fim");
            Console.ReadLine();
        }
        static string PerguntaNome()
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            return nomeCompleto;
        }
        static int PerguntasAnoNascimento()
        {
            Console.WriteLine("Digite seu ano de nascimento: ");
            int dataNascimento = Convert.ToInt32(Console.ReadLine());
            return dataNascimento;
        }
    }
}