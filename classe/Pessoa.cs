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
            Idade = DateTime.Now.Year - anoNascimento;
        }

        public void SetarNomeCompleto(string nomeCompleto)
        {
            Nome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            Sobrenome = nomeCompleto.Substring(nomeCompleto.IndexOf(" ") + 1);
        }

        public void Exibir()
        {
            Console.WriteLine($"Calculo de idade: {Idade}, nome completo: {Nome} {Sobrenome}");
        }
    }
}
