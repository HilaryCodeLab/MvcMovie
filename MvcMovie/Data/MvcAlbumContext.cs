using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcAlbumContext : DbContext
    {
        public DbSet<MvcMovie.Models.Album> Album { get; set; }
        public DbSet<MvcMovie.Models.Genre> Genres { get; set; }
        public DbSet<MvcMovie.Models.Artist> Artists { get; set; }
        public MvcAlbumContext (DbContextOptions<MvcAlbumContext> options)
            : base(options)
        {
        }   

        
    }
}
