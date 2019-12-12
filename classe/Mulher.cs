using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    class Mulher : Pessoa
    {
        public Mulher(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.feminino;
        }
    }
}
