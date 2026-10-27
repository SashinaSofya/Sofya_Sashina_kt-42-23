using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofya_Sashina_kt_42_23.Models;

namespace Sofya_Sashina_kt_42_23.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("disciplines");

            builder.HasKey(x => x.DisciplineId);

            builder.Property(x => x.DisciplineId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}