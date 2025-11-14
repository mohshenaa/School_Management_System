using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;
using School_Management_System.SecurityModels;

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
        public DbSet<Students> Students { get; set; } = default!;
        public DbSet<Departments> Departments { get; set; } = default!;
        public DbSet<Classes> Classes { get; set; } = default!;
        public DbSet<Attendance> Attendance { get; set; } = default!;
        public DbSet<Exams> Exams { get; set; } = default!;
        public DbSet<Sections> Sections { get; set; } = default!;
        public DbSet<Subjects> Subjects { get; set; } = default!;
        public DbSet<FeesCollection> FeesCollection { get; set; } = default!;
        public DbSet<FeesTypes> FeesTypes { get; set; } = default!;

        public DbSet<ClassTime> ClassTime { get; set; } = default!;

        public DbSet<Events> Events { get; set; } = default!; 
        public DbSet<Hostel> Hostel { get; set; } = default!; 
        public DbSet<HostelResidents> HostelResidents { get; set; } = default!;
        public DbSet<Messages> Messages { get; set; } = default!;
        public DbSet<Notice> Notice { get; set; } = default!; 
        public DbSet<Result> Result { get; set; } = default!; 
        public DbSet<TransportAssignments> TransportAssignments { get; set; } = default!; 
        public DbSet<TransportRoutes> TransportRoutes { get; set; } = default!; 
  

        public DbSet<Assignments> Assignments { get; set; } = default!;

        public DbSet<Submissions> Submissions { get; set; } = default!;
        public DbSet<Teachers> Teachers { get; set; } = default!;
        public DbSet<TeachersAttendance> TeachersAttendance { get; set; } = default!;
        public DbSet<Salary> Salary { get; set; } = default!;



        public DbSet<Books> Books { get; set; } = default!;

        public DbSet<IssuedBooks> IssuedBooks { get; set; } = default!;
        public DbSet<Expenses> Expenses { get; set; } = default!;


        public DbSet<ActivityLogs> ActivityLogs { get; set; } = default!;
        public DbSet<LoginLogs> LoginLogs { get; set; } = default!;

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
