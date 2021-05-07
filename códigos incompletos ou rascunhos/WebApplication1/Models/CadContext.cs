using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class CadContext : DbContext
    {
        public CadContext (DbContextOptions<CadContext> options) : base(options)
        {

        }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
