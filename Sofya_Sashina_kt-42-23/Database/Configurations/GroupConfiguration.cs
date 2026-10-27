using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofya_Sashina_kt_42_23.Models;

namespace Sofya_Sashina_kt_42_23.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("groups");

            builder.HasKey(x => x.GroupId);

            builder.Property(x => x.GroupId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Course)
                .IsRequired();

            builder.Property(x => x.SpecialityId)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.HasOne(x => x.Speciality)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.SpecialityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}