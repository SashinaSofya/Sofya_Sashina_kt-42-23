using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofya_Sashina_kt_42_23.Models;

namespace Sofya_Sashina_kt_42_23.Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("students");

            builder.HasKey(x => x.StudentId);

            builder.Property(x => x.StudentId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.GroupId)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}