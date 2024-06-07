using Microsoft.EntityFrameworkCore;
using Api.Data;
public class PatientContext : DbContext
{
    

    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Patient> Patients { get; set; }



    

    public PatientContext()
    {
    //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=Patient.db");
    // }
    }

    public PatientContext(DbContextOptions<PatientContext> options) : base(options)
    {
    }

    // protectedtected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //
    //     // Configure relationships, constraints, etc.
    //     modelBuilder.Entity<Patient>()
    //         .HasMany(p => p.Appointment)
    //         .WithOne(a => a.Patient)
    //         .HasForeignKey(a => a.PatientId);
    //
    //     modelBuilder.Entity<Patient>()
    //         .HasMany(p => p.Note)
    //         .WithOne(n => n.Patient)
    //         .HasForeignKey(n => n.PatientId);
    //
    //     modelBuilder.Entity<Doctor>()
    //         .HasMany(d => d.Appointment)
    //         .WithOne(a => a.Doctor)
    //         .HasForeignKey(a => a.DoctorId);
    // }

}
