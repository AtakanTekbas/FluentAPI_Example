using FluentExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentExample.Data
{
    public class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(k => k.BranchID);
            builder.Property(p => p.BranchID).ValueGeneratedOnAdd();
            builder.Property(p => p.BranchName).IsRequired();

            //relation - 1
            builder.HasMany(d => d.Doctors)
                .WithOne(b => b.Branch)
                .HasForeignKey(b => b.BranchID);

        }
    }
}