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
            IPecaRoupa pecaRoupa;

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

                            PecaRoupa peca = new PecaRoupa();

                            pecaRoupa = PerguntaTipoVestuario(peca);
                            pecaRoupa = PerguntaCorVestuario(peca);

                            pessoa = new Mulher(nomeFornecido);
                            ((Mulher)pessoa).DefinirVestuario(pecaRoupa);

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

                            PecaRoupa peca = new PecaRoupa();

                            pecaRoupa = PerguntaTipoVestuario(peca);
                            pecaRoupa = PerguntaCorVestuario(peca);

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
        static IPecaRoupa PerguntaTipoVestuario(PecaRoupa peca)
        {
            Console.WriteLine("\nAgora, seu vestuário.");
            Console.WriteLine("Digite 1 para camisetas | Digite 2 para calça.");
            string escolherVestuario = Console.ReadLine();

            switch (escolherVestuario)
            {
                case "1":
                    peca.DefinirPecaRoupa(TipoPecaRoupa.camisa);
                    break;

                case "2":
                    peca.DefinirPecaRoupa(TipoPecaRoupa.calça);
                    break;

                default:
                    Console.WriteLine("Este comando não é válido");
                    break;
            }
            return peca;
        }
        static IPecaRoupa PerguntaCorVestuario(PecaRoupa peca)
        {
            Console.WriteLine("\nDigite 1 para branco | Digite 2 para preto | Digite 3 para colorido");
            string escolherCorVestuario = Console.ReadLine();

            switch (escolherCorVestuario)
            {
                case "1":
                    peca.DefinirCorRoupa(CorPecaRoupa.branca);
                    break;

                case "2":
                    peca.DefinirCorRoupa(CorPecaRoupa.preta);
                    break;

                case "3":
                    peca.DefinirCorRoupa(CorPecaRoupa.colorida);
                    break;

                default:
                    Console.WriteLine("Este comando não é válido");
                    break;
            }
            return peca;
        }
    }
}