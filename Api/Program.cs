using Microsoft.EntityFrameworkCore;
using Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext with SQLite
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




// using Microsoft.EntityFrameworkCore;
// using Api.Data;
// using Api.Services;
//
// var builder = WebApplication.CreateBuilder(args);
//
// // Add services to the container.
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
//
// // Configure DbContext with SQLite
// builder.Services.AddDbContext<PatientContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//
// var app = builder.Build();
//
// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
//
// // app.UseHttpsRedirection(); // Ensure this is present and correctly configured
//
// app.UseAuthorization();
//
// app.MapControllers();
//
// // Data seeding logic
// using (var scope = app.Services.CreateScope())
// {
//     var services = scope.ServiceProvider;
//     var dbContext = services.GetRequiredService<PatientContext>();
//     DataSeeder.Seed(dbContext);
// }
//
// app.Run();
//
//
//
// // using Microsoft.EntityFrameworkCore;
// // using Api.Data;
// // using Api.Services;
// //
// // var builder = WebApplication.CreateBuilder(args);
// //
// // // Add services to the container.
// // builder.Services.AddControllers();
// // builder.Services.AddEndpointsApiExplorer();
// // builder.Services.AddSwaggerGen();
// //
// // // Configure DbContext with SQLite
// // builder.Services.AddDbContext<PatientContext>(options =>
// //     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
// //
// // var app = builder.Build();
// //
// // // Configure the HTTP request pipeline.
// // if (app.Environment.IsDevelopment())
// // {
// //     app.UseSwagger();
// //     app.UseSwaggerUI();
// // }
// //
// // app.UseHttpsRedirection(); // Ensure this is present and correctly configured
// //
// // app.UseAuthorization();
// //
// // app.MapControllers();
// //
// // app.Run();