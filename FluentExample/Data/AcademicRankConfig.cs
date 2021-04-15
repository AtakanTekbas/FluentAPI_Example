using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class AcademicRankConfig:IEntityTypeConfiguration<AcademicRank>
    {
        public void Configure(EntityTypeBuilder<AcademicRank> builder)
        {
            builder.HasKey(k => k.AcademicRankID);
            builder.Property(p => p.AcademicRankID).ValueGeneratedOnAdd();
            builder.Property(p => p.AcademicRankName).IsRequired();

            //relation - 1
            builder.HasMany(d => d.Doctors)
                .WithOne(a => a.AcademicRank)
                .HasForeignKey(a => a.AcademicRankID);

        }
    }
}