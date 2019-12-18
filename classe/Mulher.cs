namespace classe
{
    class Mulher : Pessoa, IRoupa<Mulher>
    {
        public PecaRoupa PecaRoupas { get; protected set; }
        public Mulher(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.feminino;
            DefinirVestuario(PecaRoupas);
        }
        public Mulher DefinirVestuario(IPecaRoupa pecaRoupa)
        {

            return this;
        }
    }
}
