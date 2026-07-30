
using Microsoft.EntityFrameworkCore;
using WebApi_Test.Model;

namespace WebApi_Test.DbContextData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employess { get; set; }

        public DbSet<Emp_Signup> emp_Signups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("EmpTable").HasKey(e => e.ID);

            modelBuilder.Entity<Emp_Signup>().ToTable("EmpSignup").HasKey(e => e.Id);

        }
    }
}
