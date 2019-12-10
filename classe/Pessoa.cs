using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Sexo sexoInformado { get; private set; }
        public Pessoa(string nome, string sobrenome, Sexo sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            sexoInformado = sexo;

            //Validar();
        }
        public virtual void MudarNome(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            //Validar();
        }
        public virtual void Exibir()
        {
            Console.WriteLine($"\nSeu resultado é: " + Nome.Trim() + " " + Sobrenome.Trim() + " com o sexo: " + sexoInformado);
        }
        #region Regra de negocio
        protected bool Validar(string nomeCompleto)
        {
            if (string.IsNullOrEmpty(nomeCompleto))
            {
                Console.WriteLine("Nome completo deve ser preenchido");
                return false;
            }
            return true;
        }
        #endregion
    }
}
