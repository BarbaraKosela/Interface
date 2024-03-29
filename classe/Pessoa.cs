﻿using System;
using System.Data.SqlClient;

namespace classe
{
    abstract class Pessoa : PecaRoupa, IPessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Sexo Sexo { get; protected set; }
        public int Idade { get; private set; }
        public PecaRoupa PecaRoupas { get; protected set; }
        public SqlConnection SqlConnection { get; set; }
        public SqlCommand Command { get; set; }
        public void SetarAnoNascimento(int anoNascimento)
        {
            ValidarIdade(anoNascimento);

            Idade = DateTime.Now.Year - anoNascimento;
        }
        public void SetarNomeCompleto(string nomeCompleto)
        {
            ValidarNome(nomeCompleto);

            Nome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            Sobrenome = nomeCompleto.Substring(nomeCompleto.IndexOf(" ") + 1);
        }
        public override string ToString()
        {
            return $"Seu nome é: {Nome}, sua idade é: {Idade}, seu sexo é: {Sexo}, a peça é: {PecaRoupas.TipoPeca}, e sua roupa é da cor: {PecaRoupas.CorPeca}";
        }

        #region Validações
        private void ValidarNome(string nomeCompleto)
        {
            if (!nomeCompleto.Trim().Contains(" "))
                throw new Exception("Nome deve ser completo!");

            else if (string.IsNullOrEmpty(nomeCompleto))
                throw new Exception("Nome não pode estar nulo ou vazio!");
        }
        private void ValidarIdade(int anoNascimento)
        {
            if (anoNascimento <= 0)
                throw new Exception("Ano nascimento não pode ser zero!");

            else if (anoNascimento > DateTime.Now.Year)
                throw new Exception("O ano de nascimento não pode ser superior ao ano atual!");

            else if (anoNascimento < 1900)
                throw new Exception("Ano de nascimento está inválido, deve ser superior a 1900");
        }
        #endregion
    }
}
