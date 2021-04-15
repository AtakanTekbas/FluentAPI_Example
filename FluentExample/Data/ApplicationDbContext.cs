using FluentExample.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentExample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AcademicRank> AcademicRanks { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
                       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AcademicRankConfig());
            modelBuilder.ApplyConfiguration(new BranchConfig());
            modelBuilder.ApplyConfiguration(new DiagnosticConfig());
            modelBuilder.ApplyConfiguration(new DoctorConfig());
            modelBuilder.ApplyConfiguration(new GenderConfig());
            modelBuilder.ApplyConfiguration(new MedicineConfig());
            modelBuilder.ApplyConfiguration(new PatientConfig());
        }
    }
}
