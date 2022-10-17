using GerenciamentoDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeTarefas.Context
{
  public class TarefasContext : DbContext
  {
    public TarefasContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Tarefa> Tarefas { get; set; }
  }
}
