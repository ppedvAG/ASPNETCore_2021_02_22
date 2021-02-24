using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookshopDomain.Entites;

namespace BookshopWebAPI.Data
{
    public class BookshopDBContext : DbContext
    {
        public BookshopDBContext (DbContextOptions<BookshopDBContext> options)
            : base(options)
        {
        }

        public DbSet<BookshopDomain.Entites.Book> Book { get; set; }
    }
}
