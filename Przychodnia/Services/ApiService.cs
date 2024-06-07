/*using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Przychodnia.Data;

namespace Przychodnia.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl; 
        
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = _httpClient.BaseAddress.ToString();
        }
        public async Task<List<Doctor>> GetDoctorsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Doctor>>("http://localhost:5176/api/Doctors");
        }

        public async Task<List<Patient>> GetPatientsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Patient>>("http://localhost:5176/api/api/Patients");
        }

        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Appointment>>("http://localhost:5176/api/Appointments");
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Note>>("http://localhost:5176/api/Notes");
        }

        public async Task<Patient> GetPatientAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Patient>($"http://localhost:5176/api/Patients/{id}");
        }
        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Doctor>($"http://localhost:5176/api/Doctors/{id}");
        }

        public async Task<Appointment> GetAppointmentAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Appointment>($"http://localhost:5176/api/Appointments/{id}");
        }

        public async Task<Note> GetNoteAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Note>($"http://localhost:5176/api/Notes/{id}");
        }
        public async Task<bool> AddDoctorAsync(Doctor doctor)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5176/api/Doctors", doctor);

            // Check if the response indicates success
            if (response.IsSuccessStatusCode)
            {
                // You can also read the response content if needed
                var createdDoctor = await response.Content.ReadFromJsonAsync<Doctor>();
                return true; // Or return the createdDoctor if you need to work with it
            }
            else
            {
                // Log the error or handle it as needed
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error adding doctor: {response.StatusCode}, {errorContent}");
                return false;
            }
        }


        public async Task AddPatientAsync(Patient patient)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5176/api/Patients", patient);
           
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _httpClient.PostAsJsonAsync("api/appointments", appointment);
        }

        public async Task AddNoteAsync(Note note)
        {
            await _httpClient.PostAsJsonAsync("api/notes", note);
        }
        
        public async Task UpdataDoctorAsync(Doctor doctor)
        {
            await _httpClient.PutAsJsonAsync($"api/doctors/{doctor.DoctorId}", doctor);
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            await _httpClient.PutAsJsonAsync($"api/patients/{patient.PatientId}", patient);
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await _httpClient.PutAsJsonAsync($"api/appointments/{appointment.AppointmentId}", appointment);
        }

        public async Task UpdateNoteAsync(Note note)
        {
            await _httpClient.PutAsJsonAsync($"api/notes/{note.NoteId}", note);
        }
        
        public async Task DeleteDoctorAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/doctors/{id}");
        }

        public async Task DeletePatientAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/patients/{id}");
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/appointments/{id}");
        }

        public async Task DeleteNoteAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/notes/{id}");
        }
        
        public string GetServerAddress()
        {
            return _baseUrl;
        }
    }
    
 


}
*/

using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Przychodnia.Data; 
using Przychodnia.Services;
using Newtonsoft.Json;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;

    }

	public async Task<List<Doctor>> GetDoctorsAsync()
{
    using HttpResponseMessage response = await _httpClient.GetAsync("api/doctors");
    
    response.EnsureSuccessStatusCode();
    
    var jsonResponse = await response.Content.ReadAsStringAsync();
    Console.WriteLine($"{jsonResponse}\n");
    
    return JsonConvert.DeserializeObject<List<Doctor>>(jsonResponse);
}





    /*public async Task<List<Doctor>> GetDoctorsAsync()
    {
        var response = await _httpClient.GetAsync("api/Doctors");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Doctor>>(content);
    }*/

    public async Task<Doctor> GetDoctorByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Doctor>($"api/doctors/{id}");
    }

    public async Task<List<Patient>> GetPatientsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Patient>>("api/patients");
    }

    public async Task<Patient> GetPatientByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Patient>($"api/patients/{id}");
    }
}
