namespace classe
{
    class Mulher : Pessoa, IRoupa<Mulher>
    {
        public Mulher(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.feminino;
        }
        public Mulher DefinirVestuario(IPecaRoupa pecaRoupa)
        {
            PecaRoupas = (PecaRoupa)pecaRoupa;

            return this;
        }
    }
}