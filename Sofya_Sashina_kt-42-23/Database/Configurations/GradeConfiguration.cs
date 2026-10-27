using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofya_Sashina_kt_42_23.Models;

namespace Sofya_Sashina_kt_42_23.Database.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("grades");

            builder.HasKey(x => x.GradeId);

            builder.Property(x => x.GradeId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Value)
                .IsRequired();

            builder.Property(x => x.StudentId)
                .IsRequired();

            builder.Property(x => x.DisciplineId)
                .IsRequired();

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Discipline)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.DisciplineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}