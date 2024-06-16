using CupomDesconto.Models;
using Microsoft.EntityFrameworkCore;

namespace CupomDesconto.Data
{
    public class CupomDescontoContext : DbContext
    {
        public CupomDescontoContext(DbContextOptions<CupomDescontoContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cupom> Cupom { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cupom>(entity =>
            {
                entity.Property(e => e.DataValidade)
                      .HasColumnType("timestamp without time zone");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
