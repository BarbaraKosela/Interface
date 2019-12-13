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
                string escolhaHomemMulher = Console.ReadLine();

                switch (escolhaHomemMulher)
                {
                    case "1":
                        try
                        {
                            nomeFornecido = PerguntaNome();
                            anoNascimentoFornecido = PerguntasAnoNascimento();

                            pessoa = new Mulher(nomeFornecido);
                            pessoa.SetarAnoNascimento(anoNascimentoFornecido);

                            Console.WriteLine(pessoa.ToString());
                        }
                        catch (Exception e)
                         {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "2":
                        try
                        {
                            nomeFornecido = PerguntaNome();
                            anoNascimentoFornecido = PerguntasAnoNascimento();

                            pessoa = new Homem(nomeFornecido);
                            pessoa.SetarAnoNascimento(anoNascimentoFornecido);

                            Console.WriteLine(pessoa.ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "3":
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
            int anoNascimento;

            Console.WriteLine("Digite seu ano de nascimento: ");
            string variavel = Console.ReadLine();

            bool sucesso = int.TryParse(variavel, out anoNascimento);

            if (!sucesso)
                throw new Exception("Erro! Não é aceito letras para ano de nascimento!");

            return anoNascimento;
        }
    }
}