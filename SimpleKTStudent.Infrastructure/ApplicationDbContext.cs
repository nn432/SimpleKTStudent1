using Microsoft.EntityFrameworkCore;
using SimpleKTStudent.Domain.Model;

namespace SimpleKTStudent.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Testing> Testings { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Config> Configs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Testing entity
            modelBuilder.Entity<Testing>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Begin).IsRequired();
                entity.Property(e => e.End).IsRequired();
                
                // Configure relationships
                entity.HasOne(e => e.Student)
                      .WithMany()
                      .HasForeignKey(e => e.StudentId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Configure Student entity
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
            });

            // Configure Config entity
            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Value).IsRequired();
            });
        }
    }
}
