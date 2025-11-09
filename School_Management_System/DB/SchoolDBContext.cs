using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;

namespace School_Management_System.DB
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }
        // DbSets
        public DbSet<Users> Users { get; set; } = default!;
        public DbSet<Roles> Roles { get; set; } = default!;
        public DbSet<Teachers> Teachers { get; set; } = default!;
        public DbSet<Students> Students { get; set; } = default!;
        public DbSet<Departments> Departments { get; set; } = default!;
        public DbSet<Classes> Classes { get; set; } = default!;
        public DbSet<Exams> Exams { get; set; } = default!;
        public DbSet<Sections> Sections { get; set; } = default!;
        public DbSet<Subjects> Subjects { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Email)
                .IsUnique();   //এরকম আর কি কি ইউনিক করতে হবে সবাই চিন্তা করেন বা বিকল্প ডুপ্লিকেট ভ্যালু কিভাবে রোধ করা যায়

            modelBuilder.Entity<Students>()
                .HasOne(s => s.Departments)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);   // আর কি কি রিলেশন আছে বলেন
        }

    }// অবশ্যয় কমেন্ট রাখবেন কি করলেন বা কি করতে হবে তা বলবেন।
}
