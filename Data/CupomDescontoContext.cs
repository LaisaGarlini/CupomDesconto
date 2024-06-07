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
        public DbSet<CupomDesconto.Models.Cupom> Cupom { get; set; } = default!;
    }
}
