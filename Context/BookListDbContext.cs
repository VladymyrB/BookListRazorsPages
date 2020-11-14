using BookListRazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Context
{
    public class BookListDbContext: DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
