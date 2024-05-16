using Domain.Entry;
using Infrastructure.Map;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class IctDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleDocument> ArticleDocuments { get; set; }

        public IctDbContext(DbContextOptions<IctDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMap).Assembly);
        }
    }
}
