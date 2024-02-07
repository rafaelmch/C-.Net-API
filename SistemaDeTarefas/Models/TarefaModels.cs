// Rafael Hassegawa - 04/02/2024
// Model Tarefas - pode ou não ter um usuário vinculado. Ou seja,
// posso criar uma tarefa sem um vínculo com usuário.
using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; } // can be null
        public string? Descricao { get; set; }
        public StatusTarefas Status { get; set; }
        
        // vincular usuário (ele pode ser null, sem vínculo, pois posso criar uma tarefa sem vincular a um usuário)
        public int? UsuarioId { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }
}
