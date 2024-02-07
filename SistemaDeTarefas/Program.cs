// Rafael Hassegawa - 04/02/2024
// Rafael Hassegawa - 05/02/2024
// registando a tarefa aqui na program.cs

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Reposit�rios;
using SistemaDeTarefas.Reposit�rios.Interfaces;

namespace SistemaDeTarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // configurar sql server
            builder.Services.AddEntityFrameworkSqlServer().AddDbContext<SistemaDeTarefasDBContex>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            // configurar depend�ncias do reposit�rio (usu�rios)
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            // configurar depend�ncias do reposit�rio (tarefas)
            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
