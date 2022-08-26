using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class WarrenContext : DbContext
    {
        #region Props
        public DbSet<Animal> Animal { get; set; }

        public DbSet<Planta> Planta { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5433; Database=postgres; UserId=postgres; Password=132435");
        }
    }
}
