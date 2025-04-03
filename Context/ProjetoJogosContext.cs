using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjetosJogosAPI.Domains;

namespace ProjetosJogosAPI.Context
{
    public class ProjetoJogosContext : DbContext
    {
        public ProjetoJogosContext() { }

        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options): base(options)
        {

        }

        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE31-S28\\SQLEXPRESS; DataBase = Jogo; User Id = sa; Pwd = Senai@134; TrustServerCertificate=True;");
            }
        }
    }
}
