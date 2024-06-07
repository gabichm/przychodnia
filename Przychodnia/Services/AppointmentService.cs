using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Przychodnia.Data;

namespace Przychodnia.Services
{
    public class AppointmentService
    {
        private readonly HttpClient _httpClient;

        public AppointmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Appointment>> GetAppointments()
        {
            return await _httpClient.GetFromJsonAsync<List<Appointment>>("Appointments");
        }

        public async Task<Appointment> GetAppointment(int id)
        {
            return await _httpClient.GetFromJsonAsync<Appointment>($"Appointments/{id}");
        }

        public async Task CreateAppointment(Appointment appointment)
        {
            await _httpClient.PostAsJsonAsync("Appointments", appointment);
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            await _httpClient.PutAsJsonAsync($"Appointments/{appointment.AppointmentId}", appointment);
        }

        public async Task DeleteAppointment(int id)
        {
            await _httpClient.DeleteAsync($"Appointments/{id}");
        }
    }
    

}