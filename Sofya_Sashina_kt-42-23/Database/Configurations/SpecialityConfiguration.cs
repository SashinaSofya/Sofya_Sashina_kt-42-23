using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofya_Sashina_kt_42_23.Models;

namespace Sofya_Sashina_kt_42_23.Database.Configurations
{
    public class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.ToTable("specialities");

            builder.HasKey(x => x.SpecialityId);

            builder.Property(x => x.SpecialityId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}