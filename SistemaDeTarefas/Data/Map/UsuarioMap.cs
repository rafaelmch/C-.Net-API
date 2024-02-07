// Rafael Hassegawa - 04/02/2024

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); // obrigatório com no máximo 255 caracteres
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150); // obrigatório com no máximo 150 caracteres
        }
    }
}
