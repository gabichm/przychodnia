using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services;

public class DoctorService : IDoctorService
{
    private readonly ApplicationDbContext _context;
    
    public DoctorService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Doctor>> GetDoctors()
    {
        var doctors = await _context.Doctors.ToListAsync();
        return doctors;
    }
    public async Task<Doctor> GetDoctor(int id)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        return doctor;
    }
    public async Task<Doctor> AddDoctor(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        await _context.SaveChangesAsync();
        return doctor;
    }
    public async Task<Doctor> UpdateDoctor(Doctor doctor)
    {
        _context.Entry(doctor).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return doctor;
    }
    public async Task DeleteDoctor(int id)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
    }
}