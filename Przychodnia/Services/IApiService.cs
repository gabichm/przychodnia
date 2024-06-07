namespace Przychodnia.Services;
using Przychodnia.Data;

public interface IApiService
{
    
    Task<List<Doctor>> GetDoctorsAsync();
    Task<Doctor> GetDoctorByIdAsync(int id);
    Task<List<Patient>> GetPatientsAsync();
    Task<Patient> GetPatientByIdAsync(int id);
}
