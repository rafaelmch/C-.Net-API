// Rafael Hassegawa - 04/02/2024
// Mapeamento da Tarefa, incluíndo o vínculo com o UsuarioID e o Usuario,
// já definidos no Model Tarefa.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); // obrigatório com no máximo 1000 caracteres
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1000); // obrigatório com no máximo 1000 caracteres
            builder.Property(x => x.Status).IsRequired(); // obrigatório
            // mapeamento do vínculo com o usuário
            builder.Property(x => x.UsuarioId);
            builder.HasOne(x => x.Usuario);
        }
    }
}
