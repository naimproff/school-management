using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMicroservice.Models;

namespace TeacherMicroservice.Contexts
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options): base(options)
        {

        }
        public DbSet<TeacherModel> Teachers { get; set; }
    }
}
