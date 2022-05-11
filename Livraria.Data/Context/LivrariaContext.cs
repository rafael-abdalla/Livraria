using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
        {

        }

        public DbSet<Livro>? Livro { get; set; }
    }
}
