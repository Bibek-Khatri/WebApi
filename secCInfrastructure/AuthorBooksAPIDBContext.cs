using Microsoft.EntityFrameworkCore;
using secCDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace secCInfrastructure
{
    public class AuthorBooksAPIDBContext :DbContext
    {
        public AuthorBooksAPIDBContext(DbContextOptions<AuthorBooksAPIDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorBook",
                    j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId")
                );
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
}
