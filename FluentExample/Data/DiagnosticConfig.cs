using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class DiagnosticConfig : IEntityTypeConfiguration<Diagnostic>
    {
        public void Configure(EntityTypeBuilder<Diagnostic> builder)
        {
            builder.HasKey(k => k.DiagnosticID);
            builder.Property(p => p.DiagnosticID).ValueGeneratedOnAdd();
            builder.Property(p => p.DiagnosticName).IsRequired();

            //relation - 1
            builder.HasMany(m => m.Medicines)
                .WithMany(d => d.Diagnostics);

            //relation - 2
            builder.HasMany(o => o.Patients)
                .WithMany(d => d.Diagnostics);
        }
    }
}