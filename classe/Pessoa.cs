using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Sexo Sexo { get; protected set; }
        public int Idade { get; private set; }

        public void SetarAnoNascimento(int anoNascimento)
        {
            anoNascimento = 2019 - anoNascimento;
            Console.WriteLine(anoNascimento);
        }

        public void SetarNomeCompleto(string nomeCompleto)
        {
            while (!nomeCompleto.Contains(" "))
            {
                Console.WriteLine("Digite novamente, nome não está completo!");
                nomeCompleto = Console.ReadLine();
            }



            Console.WriteLine(nomeCompleto);
        }
    }
}
