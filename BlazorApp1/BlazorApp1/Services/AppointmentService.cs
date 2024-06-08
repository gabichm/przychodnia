using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services;

public class AppointmentService : IAppointmentService
{
    private readonly ApplicationDbContext _context;

    public AppointmentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Appointment>> GetAppointments()
    {
        var appointments = await _context.Appointments.ToListAsync();
        return appointments;
    }
    public async Task<Appointment> GetAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        return appointment;
    }
    public async Task<Appointment> AddAppointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
        return appointment;
    }
    public async Task<Appointment> UpdateAppointment(Appointment appointment)
    {
        _context.Entry(appointment).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return appointment;
    }
    public async Task DeleteAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();
    }
    
}