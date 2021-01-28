using homework1.Model;
using Microsoft.EntityFrameworkCore;

namespace homework1.DataAccess
{
    public class ClassContext:DbContext
    {
        public DbSet<Corse> Corses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Studenets { get; set; }
        public DbSet<Class> Classes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Initial Catalog = Homework1; integrated security = true ");
        }


    }

}
