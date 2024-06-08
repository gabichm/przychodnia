using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using BlazorApp1.Models;
using BlazorApp1.Data;

public class DataSeeder
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public DataSeeder(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public void SeedData()
    {
        SeedAppointments();
        SeedDoctors();
        SeedNotes();

    }

    private void SeedDoctors()
    {
        if (!_context.Doctors.Any())
        {
            _context.Doctors.AddRange(
                new Doctor
                {
                    Name = "John", LastName = "Doe", Specialty = "Cardiology", Phone = "123-456-7890",
                    Email = "john@example.com"
                },
                new Doctor
                {
                    Name = "Jane", LastName = "Doe", Specialty = "Neurology", Phone = "321-654-9870",
                    Email = "jane@example.com"
                },
                new Doctor
                {
                    Name = "Jim", LastName = "Beam", Specialty = "Orthopedics", Phone = "456-789-0123",
                    Email = "jim@example.com"
                },
                new Doctor
                {
                    Name = "Jack", LastName = "Daniels", Specialty = "Pediatrics", Phone = "654-321-0987",
                    Email = "jack@example.com"
                },
                new Doctor
                {
                    Name = "Mary", LastName = "Jane", Specialty = "Dermatology", Phone = "789-012-3456",
                    Email = "mary@example.com"
                },
                new Doctor
                {
                    Name = "Anna", LastName = "Smith", Specialty = "Gynecology", Phone = "890-123-4567",
                    Email = "anna@example.com"
                },
                new Doctor
                {
                    Name = "Peter", LastName = "Parker", Specialty = "Radiology", Phone = "901-234-5678",
                    Email = "peter@example.com"
                },
                new Doctor
                {
                    Name = "Bruce", LastName = "Wayne", Specialty = "Psychiatry", Phone = "012-345-6789",
                    Email = "bruce@example.com"
                },
                new Doctor
                {
                    Name = "Clark", LastName = "Kent", Specialty = "Oncology", Phone = "123-456-7891",
                    Email = "clark@example.com"
                },
                new Doctor
                {
                    Name = "Diana", LastName = "Prince", Specialty = "Endocrinology", Phone = "234-567-8901",
                    Email = "diana@example.com"
                },
                new Doctor
                {
                    Name = "Tony", LastName = "Stark", Specialty = "General Surgery", Phone = "345-678-9012",
                    Email = "tony@example.com"
                }
            );

            _context.SaveChanges();
        }
    }

    private void SeedAppointments()
    {
        if (!_context.Appointments.Any())
        {
            _context.Appointments.AddRange(
                new Appointment
                {
                    Date = "2024-06-10", Time = "10:00", Reason = "free", PatientId = null, DoctorId = 1,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-11", Time = "11:00", Reason = "free", PatientId = null, DoctorId = 2,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-12", Time = "12:00", Reason = "free", PatientId = null, DoctorId = 3,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-13", Time = "13:00", Reason = "free", PatientId = null, DoctorId = 4,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-14", Time = "14:00", Reason = "free", PatientId = null, DoctorId = 5,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-15", Time = "15:00", Reason = "free", PatientId = null, DoctorId = 1,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-16", Time = "16:00", Reason = "free", PatientId = null, DoctorId = 2,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-17", Time = "17:00", Reason = "free", PatientId = null, DoctorId = 3,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-18", Time = "18:00", Reason = "free", PatientId = null, DoctorId = 4,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-19", Time = "19:00", Reason = "free", PatientId = null, DoctorId = 5,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-20", Time = "10:00", Reason = "free", PatientId = null, DoctorId = 1,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-21", Time = "11:00", Reason = "free", PatientId = null, DoctorId = 2,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-22", Time = "12:00", Reason = "free", PatientId = null, DoctorId = 3,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-23", Time = "13:00", Reason = "free", PatientId = null, DoctorId = 4,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-24", Time = "14:00", Reason = "free", PatientId = null, DoctorId = 5,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-25", Time = "15:00", Reason = "free", PatientId = null, DoctorId = 1,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-26", Time = "16:00", Reason = "free", PatientId = null, DoctorId = 2,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-27", Time = "17:00", Reason = "free", PatientId = null, DoctorId = 3,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-28", Time = "18:00", Reason = "free", PatientId = null, DoctorId = 4,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-29", Time = "19:00", Reason = "free", PatientId = null, DoctorId = 5,
                    Status = "free"
                },
                new Appointment
                {
                    Date = "2024-06-10", Time = "10:00", Reason = "Checkup", PatientId = 1, DoctorId = 1,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-11", Time = "11:00", Reason = "Consultation", PatientId = 2, DoctorId = 2,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-12", Time = "12:00", Reason = "Follow-up", PatientId = 3, DoctorId = 3,
                    Status = "Completed"
                },
                new Appointment
                {
                    Date = "2024-06-13", Time = "13:00", Reason = "Vaccination", PatientId = 4, DoctorId = 4,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-14", Time = "14:00", Reason = "Routine checkup", PatientId = 5, DoctorId = 5,
                    Status = "Cancelled"
                },
                new Appointment
                {
                    Date = "2024-06-15", Time = "15:00", Reason = "Physical Therapy", PatientId = 6, DoctorId = 6,
                    Status = "Completed"
                },
                new Appointment
                {
                    Date = "2024-06-16", Time = "16:00", Reason = "Dental Cleaning", PatientId = 7, DoctorId = 7,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-17", Time = "17:00", Reason = "Surgery Follow-up", PatientId = 8, DoctorId = 8,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-18", Time = "18:00", Reason = "Eye Exam", PatientId = 9, DoctorId = 9,
                    Status = "Completed"
                },
                new Appointment
                {
                    Date = "2024-06-19", Time = "19:00", Reason = "Hearing Test", PatientId = 10, DoctorId = 10,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-20", Time = "20:00", Reason = "Skin Check", PatientId = 1, DoctorId = 11,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-21", Time = "21:00", Reason = "Nutrition Counseling", PatientId = 2, DoctorId = 1,
                    Status = "Completed"
                },
                new Appointment
                {
                    Date = "2024-06-22", Time = "22:00", Reason = "Mental Health Check", PatientId = 3, DoctorId = 2,
                    Status = "Scheduled"
                },
                new Appointment
                {
                    Date = "2024-06-23", Time = "23:00", Reason = "Allergy Test", PatientId = 4, DoctorId = 3,
                    Status = "Cancelled"
                },
                new Appointment
                {
                    Date = "2024-06-24", Time = "08:00", Reason = "General Checkup", PatientId = 5, DoctorId = 4,
                    Status = "Scheduled"
                }
            );



            _context.SaveChanges();
        }
    }

    private void SeedNotes()
    {
        if (!_context.Notes.Any())
        {
            _context.Notes.AddRange(
                new Note
                {
                    AppointmentId = 1, Summary = "Patient is doing well.", Prescription = "Prescription details here."
                },
                new Note
                {
                    AppointmentId = 2, Summary = "Needs follow-up in 2 weeks.",
                    Prescription = "Prescription details here."
                },
                new Note
                {
                    AppointmentId = 3, Summary = "Physical therapy recommended.",
                    Prescription = "Prescription details here."
                },
                new Note
                {
                    AppointmentId = 4, Summary = "Vaccination completed.", Prescription = "No prescription needed."
                },
                new Note
                {
                    AppointmentId = 5, Summary = "Routine checkup, no issues.", Prescription = "No prescription needed."
                },
                new Note
                {
                    AppointmentId = 6, Summary = "Physical therapy session successful.",
                    Prescription = "Continue exercises at home."
                },
                new Note
                {
                    AppointmentId = 7, Summary = "Teeth cleaned, no cavities.", Prescription = "Brush twice daily."
                },
                new Note
                {
                    AppointmentId = 8, Summary = "Surgery follow-up, healing well.",
                    Prescription = "Continue prescribed medication."
                },
                new Note
                {
                    AppointmentId = 9, Summary = "Vision is good, no changes needed.",
                    Prescription = "No prescription needed."
                },
                new Note
                {
                    AppointmentId = 10, Summary = "Hearing test normal.", Prescription = "No prescription needed."
                },
                new Note
                {
                    AppointmentId = 11, Summary = "Skin check, no issues.", Prescription = "Use sunscreen daily."
                },
                new Note
                {
                    AppointmentId = 12, Summary = "Discussed nutrition and diet.", Prescription = "Don't do it."
                }
            );

            _context.SaveChanges();
        }
    }
}
    

