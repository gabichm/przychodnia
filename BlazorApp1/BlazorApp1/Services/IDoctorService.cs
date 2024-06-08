using BlazorApp1.Models;

namespace BlazorApp1.Services;

public interface IDoctorService
{
    Task<List<Doctor>> GetDoctors();
    Task<Doctor> GetDoctor(int id);
    Task<Doctor> AddDoctor(Doctor doctor); 
    Task<Doctor> UpdateDoctor(Doctor doctor);
    Task DeleteDoctor(int id);
}