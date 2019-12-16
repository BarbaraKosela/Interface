namespace classe
{
    public interface IRoupa
    {
        TipoPecaRoupa TipoPeca { get; }
        CorPecaRoupa CorPeca { get; }

        //
        // PecaRoupa - classe com cor e tipo

        //
        // TipoPecaRoupa - enum com camisa, calca

        //
        // CorPecaRoupa - enum com as cores, branca, preta e colorida/*
        PecaRoupa DefinirPecaRoupa(TipoPecaRoupa pecaRoupa);

        void DefinirCorPecaRoupa(CorPecaRoupa corPeca);
        PecaRoupa DefinirPecaRoupa(TipoPecaRoupa pecaRoupa);
        void DefinirCorPecaRoupa(CorPecaRoupa corPeca);
        PecaRoupa DefinirPecaRoupa(TipoPecaRoupa pecaRoupa);
    }
}
