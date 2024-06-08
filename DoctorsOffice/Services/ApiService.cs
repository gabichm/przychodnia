using System.Net.Http.Json;
using DoctorsOffice.Models;

namespace DoctorsOffice.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5176/");
        }

        // GET methods
        public async Task<List<Doctor>> GetDoctorsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Doctor>>("api/doctors");
        }

        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Doctor>($"api/doctors/{id}");
        }

        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Appointment>>("api/Appointments");
        }

        public async Task<Appointment> GetAppointmentAsync(int appointmentId)
        {
            return await _httpClient.GetFromJsonAsync<Appointment>($"api/appointments/{appointmentId}");
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Note>>("api/notes");
        }

        public async Task<Note> GetNoteAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Note>($"api/notes/{id}");
        }

        public async Task<List<Patient>> GetPatientsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Patient>>("api/patients");
        }

        public async Task<Patient> GetPatientAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Patient>($"api/patients/{id}");
        }

        // POST methods
        public async Task<HttpResponseMessage> PostDoctorAsync(Doctor doctor)
        {
            return await _httpClient.PostAsJsonAsync("api/doctors", doctor);
        }

        public async Task<HttpResponseMessage> PostAppointmentAsync(Appointment appointment)
        {
            return await _httpClient.PostAsJsonAsync("api/appointments", appointment);
        }

        public async Task<HttpResponseMessage> PostNoteAsync(Note note)
        {
            return await _httpClient.PostAsJsonAsync("api/notes", note);
        }

        public async Task<HttpResponseMessage> PostPatientAsync(Patient patient)
        {
            return await _httpClient.PostAsJsonAsync("api/patients", patient);
        }

        // DELETE methods
        public async Task<HttpResponseMessage> DeleteDoctorAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/doctors/{id}");
        }

        public async Task<HttpResponseMessage> DeleteAppointmentAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/appointments/{id}");
        }

        public async Task<HttpResponseMessage> DeleteNoteAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/notes/{id}");
        }

        public async Task<HttpResponseMessage> DeletePatientAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/patients/{id}");
        }

        // PUT methods
        public async Task<HttpResponseMessage> UpdateDoctorAsync(int id, Doctor doctor)
        {
            return await _httpClient.PutAsJsonAsync($"api/doctors/{id}", doctor);
        }

        public async Task<HttpResponseMessage> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            return await _httpClient.PutAsJsonAsync($"api/appointments/{id}", appointment);
        }

        public async Task<HttpResponseMessage> UpdateNoteAsync(int id, Note note)
        {
            return await _httpClient.PutAsJsonAsync($"api/notes/{id}", note);
        }

        public async Task<HttpResponseMessage> UpdatePatientAsync(int id, Patient patient)
        {
            return await _httpClient.PutAsJsonAsync($"api/patients/{id}", patient);
        }
    }
}
