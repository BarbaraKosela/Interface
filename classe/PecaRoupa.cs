﻿namespace classe
{
    class PecaRoupa : IPecaRoupa
    {
        public TipoPecaRoupa TipoPeca { get; protected set; }
        public CorPecaRoupa CorPeca { get; protected set; }

        public IPecaRoupa DefinirCorRoupa(CorPecaRoupa cor)
        {
            this.CorPeca = cor;
            return this;
        }

        public IPecaRoupa DefinirPecaRoupa(TipoPecaRoupa tipo)
        {
            this.TipoPeca = tipo;
            return this;
        }
    }
}