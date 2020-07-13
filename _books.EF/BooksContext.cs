using System;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace _books.EF
{
    public class BooksContext : DbContext 
    {
        public DbSet<Book> Books { get; set; }
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }
    }
}
