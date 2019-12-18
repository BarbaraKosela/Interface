namespace classe
{
    class Homem : Pessoa, IRoupa<Homem>
    {
        public PecaRoupa PecaRoupas { get; protected set; }

        public Homem(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.masculino;
            DefinirVestuario(PecaRoupas);
        }
        public Homem DefinirVestuario(IPecaRoupa pecaRoupa)
        {
            return this;
        }
    }
}
