// Rafael Hassegawa - 05/02/2024
// Criação da interface da Tarefa
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositórios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefa);
        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
