using Microsoft.EntityFrameworkCore;
using SimpleKTStudent.Domain.Model;

namespace SimpleKTStudent.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Testing> Testings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Можно настроить Fluent API маппинг здесь при необходимости
        }
    }
}
