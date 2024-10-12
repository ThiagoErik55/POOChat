using Microsoft.EntityFrameworkCore;
using ChatApp.Models;

namespace ChatApp.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<MensagemTexto> MensagensTexto { get; set; }
        public DbSet<MensagemArquivo> MensagensArquivo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ChatApp.db");
        }
    }
}
