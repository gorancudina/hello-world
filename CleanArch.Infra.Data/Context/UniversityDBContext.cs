using Microsoft.EntityFrameworkCore;
using CleanArch.Models.Domain;
namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options):base(options)
        { }

        public DbSet<Course> Courses { get; set; }
    }
}
