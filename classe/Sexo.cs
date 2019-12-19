using System.ComponentModel;


namespace classe
{
    public enum Sexo
    {
        [Description("Feminino")]
        feminino = 0,
        [Description("Masculino")]
        masculino = 1,
        [Description("Outro")]
        outro = 2,
    }
}
