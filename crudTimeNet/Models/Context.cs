using Microsoft.EntityFrameworkCore;

namespace crudTimeNet.Models
{
    public class Context: DbContext {
        public Context (DbContextOptions options) : base (options) {
        }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Jogo> Jogos {get; set; }
    }
}