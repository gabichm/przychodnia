using System.Linq;
using Api.Data;

namespace Api.Services
{
    public static class DataSeeder
    {
        public static void Seed(PatientContext dbContext)
        {
            // Check if there is already data in the database
            if (dbContext.Doctors.Any() || dbContext.Patients.Any() || dbContext.Appointments.Any() ||
                dbContext.Notes.Any())
            {
                return; // Data already seeded, no need to seed again
            }

            // Seed Doctors
            dbContext.Doctors.AddRange(
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

            // Seed Patients
            dbContext.Patients.AddRange(
                new Patient
                {
                    Name = "Alice", LastName = "Smith", Address = "123 Main St", Phone = "987-654-3210",
                    Email = "alice@example.com"
                },
                new Patient
                {
                    Name = "Bob", LastName = "Jones", Address = "456 Oak St", Phone = "876-543-2109",
                    Email = "bob@example.com"
                },
                new Patient
                {
                    Name = "Charlie", LastName = "Brown", Address = "789 Pine St", Phone = "765-432-1098",
                    Email = "charlie@example.com"
                },
                new Patient
                {
                    Name = "David", LastName = "Wilson", Address = "101 Maple St", Phone = "654-321-0987",
                    Email = "david@example.com"
                },
                new Patient
                {
                    Name = "Eve", LastName = "Davis", Address = "202 Birch St", Phone = "543-210-9876",
                    Email = "eve@example.com"
                },
                new Patient
                {
                    Name = "Frank", LastName = "Miller", Address = "303 Cedar St", Phone = "432-109-8765",
                    Email = "frank@example.com"
                },
                new Patient
                {
                    Name = "Grace", LastName = "Lee", Address = "404 Elm St", Phone = "321-098-7654",
                    Email = "grace@example.com"
                },
                new Patient
                {
                    Name = "Hank", LastName = "Moore", Address = "505 Spruce St", Phone = "210-987-6543",
                    Email = "hank@example.com"
                },
                new Patient
                {
                    Name = "Ivy", LastName = "Taylor", Address = "606 Fir St", Phone = "109-876-5432",
                    Email = "ivy@example.com"
                },
                new Patient
                {
                    Name = "Jack", LastName = "Anderson", Address = "707 Poplar St", Phone = "098-765-4321",
                    Email = "jack@example.com"
                }
            );

            // Seed Appointments
            dbContext.Appointments.AddRange(
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

            // Seed Notes
            dbContext.Notes.AddRange(
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
            dbContext.SaveChanges();
        }
    }
}   

