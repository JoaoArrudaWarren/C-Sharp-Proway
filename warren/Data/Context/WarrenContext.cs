using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class WarrenContext : DbContext
    {
        #region Props
        public DbSet<Animal> Animal { get; set; }

        public DbSet<Planta> Planta { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=192.168.0.85; Port=5433; Database=postgres; UserId=postgres; Password=132435");
        }
    }
}
