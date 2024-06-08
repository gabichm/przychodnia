using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services;

public interface IAppointmentService
{
    Task<List<Appointment>> GetAppointments();
    Task<Appointment> GetAppointment(int id);
    Task<Appointment> AddAppointment(Appointment appointment);
    Task<Appointment> UpdateAppointment(Appointment appointment);
    Task DeleteAppointment(int id);
}