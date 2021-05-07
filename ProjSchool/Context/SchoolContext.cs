using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SchoolProjEF.Models;

namespace SchoolProjEF.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Data Source=.;Initial Catalog=SchoolDB-ByConnectionString;Integrated Security=true; providerName=System.Data.SqlClient")
        {
            //Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Entity<Student>().ToTable("StudentInfo");
        }
    }
}
