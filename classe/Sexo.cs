using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public enum Sexo
    {
        [Description("Feminino")]
        feminino = 0,
        [Description("Masculino")]
        masculino = 1,
        [Description("Outro(a)")]
        outro = 2,
    }
}
