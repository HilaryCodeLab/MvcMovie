using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcBookGenreContext : DbContext
    {
        public MvcBookGenreContext (DbContextOptions<MvcBookGenreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.BookGenre> BookGenre { get; set; } = default!;
    }
}
