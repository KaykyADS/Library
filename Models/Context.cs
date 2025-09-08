using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany()
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Author)
                .WithMany()
                .HasForeignKey(l => l.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Biblioteca.Models.Author> Author { get; set; } = default!;
        public DbSet<Biblioteca.Models.Loan> Emprestimo { get; set; } = default!;
    }
}
