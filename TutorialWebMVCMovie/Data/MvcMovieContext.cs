using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using TutorialWebMVCMovie.Models;

namespace TutorialWebMVCMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}