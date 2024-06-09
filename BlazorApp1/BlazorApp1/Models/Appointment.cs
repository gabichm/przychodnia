namespace BlazorApp1.Models;

public class Appointment
{
    public string AppointmentId { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string? Reason { get; set; }
    public string? PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Status { get; set; }
}