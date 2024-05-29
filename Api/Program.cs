using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext with SQLite
var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings:DefaultConnection");
builder.Services.AddDbContext<PatientContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


// // using Microsoft.EntityFrameworkCore;
// // using PatientsApi.Data;

// // var builder = WebApplication.CreateBuilder(args);

// // // Add services to the container.
// // builder.Services.AddControllers();
// // builder.Services.AddEndpointsApiExplorer();
// // builder.Services.AddSwaggerGen();

// // // Configure DbContext with SQLite
// // builder.Services.AddDbContext<PatientsContext>(options =>
// //     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// // var app = builder.Build();

// // // Configure the HTTP request pipeline.
// // if (app.Environment.IsDevelopment())
// // {
// //     app.UseSwagger();
// //     app.UseSwaggerUI();
// // }

// // app.UseHttpsRedirection();

// // app.UseAuthorization();

// // app.MapControllers();

// // app.Run();






// using System;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         using (var db = new PatientContext())
//         {
//             // Ensure database is created
//             db.Database.EnsureCreated();

//             // Create
//             Console.WriteLine("Inserting a new book");
//             db.Patient.Add(new Patient { PatientId = 1, Name = "George",  LastName = "Orwell", Address = "London", Phone = "123456789", Email = "go@gmail.com"});
//             db.Doctor.Add(new Doctor { DoctorId = 1, Name = "George",  LastName = "Orwell", Specialty = "Psychiatry", Phone = "123456789", Email = "go@gmail.com"});
//             db.Appointment.Add(new Appointment { AppointmentId = 1, Date = "2021-10-10", Time = "10:00", Reason = "Checkup", PatientId = 1, DoctorId = 1, Status = "Pending" });
//             db.Note.Add(new Note { NoteId = 1, AppointmentId = 1,  Summary = "Patient has a history of heart disease", Prescription= "Aspirin"});
//             db.SaveChanges();


//             // Read
//             Console.WriteLine("Querying for a book");
//             var patient = db.Patient
//                 // .OrderBy(p => patient.PatientId)
//                 .First();
//             Console.WriteLine($"Book: {patient.Name}, Author: {patient.LastName}");

//             foreach (var doctor in db.Doctor)
//             {
//                 Console.WriteLine($"Book: {doctor.Name}, Author: {doctor.LastName}, Published Date: {doctor.Specialty}");
//             }

//             // Update
//             Console.WriteLine("Updating the book");
//             patient.Phone= "234567876543";
//             db.SaveChanges();


//         }

//         // Verifying data is persisted
//         using (var db = new PatientContext())
//         {
//             var notes = db.Note.ToList();
//             Console.WriteLine("Books in database after program restarts:");
//             foreach (var n in notes)
//             {
//                 Console.WriteLine($"Book: {n.NoteId}, Author: {n.AppointmentId}, Published Date: {n.Summary}, ISBN: {n.Prescription}");
//             }
//         }
//     }
// }
