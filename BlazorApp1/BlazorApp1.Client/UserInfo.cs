namespace BlazorApp1.Client;

// Add properties to this class and update the server and client AuthenticationStateProviders
// to expose more information about the authenticated user to the client.
public class UserInfo
{
    public required string UserId { get; set; }
    public required string Email { get; set; }
    public required string Role { get; set; }
}

// public class Appointment
// {
//     public int AppointmentId { get; set; }
//     public string Date { get; set; }
//     public string Time { get; set; }
//     public string? Reason { get; set; }
//     public int? PatientId { get; set; }
//     public int DoctorId { get; set; }
//     public string Status { get; set; }
// }
//
// public class Doctor
// {
//     public int DoctorId { get; set; }
//     public string Name { get; set; }
//     public string Specialty { get; set; }
//     public string LastName { get; set; }
//     public string Phone { get; set; }
//     public string Email { get; set; }
// }
//
// public class Note
// {
//     public int NoteId { get; set; }
//     public int AppointmentId { get; set; }
//     public string? Summary { get; set; }
//     public string Prescription { get; set; }
// }