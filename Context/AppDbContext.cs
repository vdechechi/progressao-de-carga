using Microsoft.EntityFrameworkCore;
using ProgessaoDeCarga.Models;

namespace ProgessaoDeCarga.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Sessao_Treino> SessoesTreino { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Sessao_Treino_Exercicio> SessaoTreinoExercicios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }


}
