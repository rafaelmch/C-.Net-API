// Rafael Hassegawa - 04/02/2024

using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefas
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3
    }
}
