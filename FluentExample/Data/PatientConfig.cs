using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class PatientConfig:IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(k => k.PatientID);
            builder.Property(p => p.PatientID).ValueGeneratedOnAdd();
            builder.Property(p => p.PatientName).IsRequired().HasMaxLength(30).HasColumnName("Name");
            builder.Property(p => p.PatientSurname).IsRequired().HasMaxLength(30).HasColumnName("Surname");
            builder.Property(p => p.PatientAge).HasColumnName("Age");

            //relation - 1
            builder.HasOne(g => g.Gender)
                .WithMany(a => a.Patients)
                .HasForeignKey(g => g.GenderID);

            //relation -2
            builder.HasOne(d => d.Doctor)
                .WithMany(a => a.Patients)
                .HasForeignKey(d => d.DoctorID);

            //relation - 3
            builder.HasMany(a => a.Diagnostics)
                .WithMany(t => t.Patients);
        }
    }
}