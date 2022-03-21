using Microsoft.EntityFrameworkCore;
using MiniTodo.Model;

namespace MiniTodo.Data
{
    public class AppDbContext : DbContext
    {
        //Banco de dados em memória
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("Datasource=app.db;Cache=Shared");

    }
}
