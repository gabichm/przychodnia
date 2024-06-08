namespace DoctorsOffice.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string? Reason { get; set; }
    public int? PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Status { get; set; }
}