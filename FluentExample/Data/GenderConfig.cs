using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class GenderConfig:IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(k => k.GenderID);
            builder.Property(p => p.GenderID).ValueGeneratedOnAdd();
            builder.Property(p => p.GenderName).IsRequired().HasColumnName("Gender");

            //relation - 1
            builder.HasMany(a => a.Patients)
                .WithOne(g => g.Gender)
                .HasForeignKey(g => g.GenderID);
        }
    }
}