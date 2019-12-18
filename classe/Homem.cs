namespace classe
{
    class Homem : Pessoa, IRoupa<Homem>
    {
        public Homem(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.masculino;
        }
        public Homem DefinirVestuario(IPecaRoupa pecaRoupa)
        {
            PecaRoupas = (PecaRoupa)pecaRoupa;

            return this;
        }
    }
}