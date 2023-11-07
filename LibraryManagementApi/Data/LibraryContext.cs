using Microsoft.EntityFrameworkCore;
using LibraryManagementApi.Models;

namespace LibraryManagementApi.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }

    // If you have any entity configurations or model relationships, they would be set up here.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Example of setting up a model relationship
        // modelBuilder.Entity<Book>()
        //     .HasOne(b => b.Author)
        //     .WithMany(a => a.Books)
        //     .HasForeignKey(b => b.AuthorId);
    }
}
