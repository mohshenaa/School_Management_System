using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;

namespace School_Management_System.DB
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; } = default!;
        public DbSet<Roles> Roles { get; set; } = default!;
        public DbSet<Teachers> Teachers { get; set; } = default!;
        public DbSet<Students> Students { get; set; } = default!;
      public DbSet<Departments> Departments { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Sections> Sections { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

    }
}
