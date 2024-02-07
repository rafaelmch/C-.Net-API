// Rafael Hassegawa - 04/02/2024
// esta interface terá nossos contratos de usuário
// buscar, adicionar, remover usuário, etc

using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositórios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id); //id do usuário que quero atualizar
        Task<bool> Apagar(int id); //id do usuário que quero deletar
    }
}
