using Microsoft.EntityFrameworkCore;
using pruebaBackend.Domain.Entities;

namespace pruebaBackend.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Brands> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\local;Database=pruebaBackend;User Id=sa3;Password=Administrator2");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(x => x.HasKey(o => o.Id));
            modelBuilder.Entity<Cars>()
                .HasOne(b => b.Brand)
                .WithMany()
                .HasForeignKey(b => b.BrandId)
                .IsRequired();

            modelBuilder.Entity<Cars>().OwnsOne(o => o.Model, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Model");
            });
            modelBuilder.Entity<Cars>().OwnsOne(o => o.Description, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Description");
            });
            modelBuilder.Entity<Cars>().OwnsOne(o => o.Km, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Km");
            });
            modelBuilder.Entity<Cars>().OwnsOne(o => o.Price, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Price");
            });

            modelBuilder.Entity<Brands>(x => x.HasKey(o => o.Id));
            modelBuilder.Entity<Brands>().OwnsOne(o => o.Name, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Name");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
