using prova_dsv_back;
using Microsoft.EntityFrameworkCore;

namespace prova_dsv_back {  
    public partial class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options)
          : base(options){}
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasIndex(b => new { b.Id })
                .IsUnique(true);

        }
    }
}