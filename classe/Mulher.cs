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
