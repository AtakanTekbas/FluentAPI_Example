using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class MedicineConfig:IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasKey(k => k.MedicineID);
            builder.Property(p => p.MedicineID).ValueGeneratedOnAdd();
            builder.Property(p => p.MedicineName).IsRequired().HasMaxLength(40);

            //relation - 1
            builder.HasMany(d => d.Diagnostics)
                .WithMany(m => m.Medicines);
        }
    }
}