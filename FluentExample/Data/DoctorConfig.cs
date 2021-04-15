using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class DoctorConfig:IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(k => k.DoctorID);
            builder.Property(p => p.DoctorID).ValueGeneratedOnAdd();
            builder.Property(p => p.DoctorName).IsRequired().HasMaxLength(20);
            builder.Property(p => p.DoctorSurname).IsRequired().HasMaxLength(20);

            //relation - 1
            builder.HasOne(b => b.Branch)
                .WithMany(d => d.Doctors)
                .HasForeignKey(b => b.BranchID);

            //relation - 2
            builder.HasOne(a => a.AcademicRank)
                .WithMany(d => d.Doctors)
                .HasForeignKey(a => a.AcademicRankID);

            //relation - 3
            builder.HasMany(p => p.Patients)
                .WithOne(d => d.Doctor)
                .HasForeignKey(p => p.DoctorID);


        }
    }
}