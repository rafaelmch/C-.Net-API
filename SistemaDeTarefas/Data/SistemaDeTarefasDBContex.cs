// Rafael Hassegawa - 04/02/2024// aqui, vamos configurar as tabelas e as configurações gerais do banco de dados
// por exemplo, a UsuarioModel representa uma tabela no banco de dados
// ao rodar o script do Migration do Entity, ele vai criar uma tabela de nome Usuarios
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaDeTarefasDBContex : DbContext
    {
        public SistemaDeTarefasDBContex(DbContextOptions<SistemaDeTarefasDBContex> options)
            : base(options) //construtor
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; } // facilita o trabalho com o banco de dados, independente do banco de dados
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
