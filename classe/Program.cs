using System;
using System.Data;
using System.Data.SqlClient;

namespace classe
{
    class Program
    {
        public static SqlConnection sql;
        public static SqlCommand cmd;
        public const string caminhoConexao = @"Data Source=DESKTOP-ND48MDH\SQLEXPRESS;Initial Catalog=Pessoa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            sql = new SqlConnection(caminhoConexao);
            sql.Open();

            cmd = new SqlCommand();
            cmd.Connection = sql;

            Pessoa pessoa;
            string nomeFornecido;
            int anoNascimentoFornecido;
            bool continuePerguntas = true;
            IPecaRoupa pecaRoupa;


            Console.WriteLine("inicio");

            while (continuePerguntas)
            {
                Console.WriteLine("Digite 1 se for mulher | Digite 2 se for homem: | Digite 3 para sair | 4 mostrar dados do banco");
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

                            InserirDadosBanco(nomeFornecido, anoNascimentoFornecido, pessoa.Sexo, peca);

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

                            InserirDadosBanco(nomeFornecido, anoNascimentoFornecido, pessoa.Sexo, peca);

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

                    case "4":
                        MostrarDadosBanco();
                        break;

                    default:
                        Console.WriteLine("Este comando não é válido");
                        break;
                }
            }
            sql.Close();

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

        static void InserirDadosBanco(string nomeCompleto, int anoNascimento, Sexo sexo, PecaRoupa pecaRoupa)
        {
            cmd.CommandText = "INSERT INTO Pessoa VALUES (@NOMECOMPLETO, @ANONASCIMENTO, @SEXO, @TIPOPECA, @CORPECA)";

            cmd.Parameters.AddWithValue("@NOMECOMPLETO", nomeCompleto);
            cmd.Parameters.AddWithValue("@ANONASCIMENTO", anoNascimento);
            cmd.Parameters.AddWithValue("@SEXO", sexo);
            cmd.Parameters.AddWithValue("@TIPOPECA", pecaRoupa.TipoPeca);
            cmd.Parameters.AddWithValue("@CORPECA", pecaRoupa.CorPeca);

            cmd.ExecuteNonQuery();
        }

        static void MostrarDadosBanco()
        {
            cmd.CommandText = "SELECT NomeCompleto, AnoNascimento, Sexo, TipoPeca, CorPeca FROM Pessoa";

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow linha = dataTable.Rows[i];

                string nomeCompleto = linha[0].ToString();
                int anoNascimento = Convert.ToInt32(linha[1].ToString());
                Sexo sexo = (Sexo)Enum.Parse(typeof(Sexo), (linha[2]).ToString());
                TipoPecaRoupa pecaRoupa = (TipoPecaRoupa)Enum.Parse(typeof(TipoPecaRoupa), (linha[3]).ToString());
                CorPecaRoupa corPeca = (CorPecaRoupa)Enum.Parse(typeof(CorPecaRoupa), (linha[4]).ToString());

                Console.WriteLine($"Nome:{nomeCompleto}, idade: {anoNascimento}, sexo: {sexo}, tipo de peça de roupa: {pecaRoupa} e cor da peça: {corPeca}");
            }

            if (dataTable.Rows.Count == 0)
                Console.WriteLine("Ainda não há registros aqui");

            cmd.ExecuteNonQuery();
        }
    }
}