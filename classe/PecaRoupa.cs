using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class PecaRoupa : IRoupa
    {
        public TipoPecaRoupa TipoPeca { get; protected set; }
        public CorPecaRoupa CorPeca { get; protected set; }

        public void DefinirCorPecaRoupa(CorPecaRoupa corPeca)
        {
            CorPeca = corPeca;
        }

        public PecaRoupa DefinirPecaRoupa(TipoPecaRoupa pecaRoupa)
        {
            PecaRoupa peca = new PecaRoupa();
            TipoPeca = pecaRoupa;
            return peca;
        }
    }
}
