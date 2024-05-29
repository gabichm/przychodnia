using Microsoft.EntityFrameworkCore;

// namespace PatientsApi.Data
public class PatientContext : DbContext
{
    

    public DbSet<Appointment> Appointment { get; set; }
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Note> Note { get; set; }
    public DbSet<Patient> Patient { get; set; }



    

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

}
