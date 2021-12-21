using Microsoft.EntityFrameworkCore;
using StudentMicroservice.Models;

namespace StudentMicroservice.Contexts
{
    public class StdDbContext : DbContext
    {
        public StdDbContext(DbContextOptions<StdDbContext> options) : base(options)
        {

        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
