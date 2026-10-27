using Microsoft.EntityFrameworkCore;
using Sofya_Sashina_kt_42_23.Models;
using Sofya_Sashina_kt_42_23.Database.Configurations;

namespace Sofya_Sashina_kt_42_23.Database
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speciality> Specialities { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SpecialityConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}