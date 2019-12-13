namespace classe
{
    class Homem : Pessoa
    {
        public Homem(string nomeCompleto)
        {
            SetarNomeCompleto(nomeCompleto);
            Sexo = Sexo.masculino;
        }
    }
}
