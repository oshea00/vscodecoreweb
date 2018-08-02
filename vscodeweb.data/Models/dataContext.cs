using Microsoft.EntityFrameworkCore;

namespace vscodeweb.data.Models {

    public class dataContext : DbContext {
        public dataContext()
        {

        }

        public dataContext(DbContextOptions<dataContext> options)
         : base(options)
         {}

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured)
            {
                builder.UseInMemoryDatabase("todos");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pgcrypto");

            modelBuilder.Entity<Todos>(entity =>
            {
                entity.ToTable("todos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsComplete).HasColumnName("iscomplete");
            });
        }

        public DbSet<Todos> Todos { get; set; }
    }
}