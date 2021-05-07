using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using AppEntVC.Models;


namespace AppEntVC.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<CadSimples> CadSimples {get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;User Id=root;Password=061127;Database=apptestewin");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CadMap());
        }
    }    
}
