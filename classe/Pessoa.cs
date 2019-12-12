using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    abstract class Pessoa : IPessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Sexo Sexo { get; protected set; }
        public int Idade { get; private set; }

        public void SetarAnoNascimento(int anoNascimento)
        {
            if (anoNascimento == 0)
                throw new Exception("Ano nascimento não pode ser zero!");

            Idade = DateTime.Now.Year - anoNascimento;
        }

        public void SetarNomeCompleto(string nomeCompleto)
        {
            if (string.IsNullOrEmpty(nomeCompleto))
                throw new Exception("Nome não pode estar nulo ou vazio!");

            Nome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            Sobrenome = nomeCompleto.Substring(nomeCompleto.IndexOf(" ") + 1);
        }
        //public void PerguntasUsuario(string nomeCompleto, int dataNascimento)
        //{
        //    Console.WriteLine("Digite seu nome completo: ");
        //    nomeCompleto = Console.ReadLine();
        //    Console.WriteLine("Digite seu ano de nascimento: ");
        //    dataNascimento = Convert.ToInt32(Console.ReadLine());
        //}
        public void Exibir()
        {
            Console.WriteLine($"Calculo de idade: {Idade}, nome completo: {Nome} {Sobrenome}");
        }
    }
}
