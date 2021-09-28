using Microsoft.EntityFrameworkCore;
using StudentMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
