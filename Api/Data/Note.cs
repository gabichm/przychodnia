namespace Api.Data
{
    public class Note
    {
        public int NoteId { get; set; }
        public int AppointmentId { get; set; }
        public string? Summary { get; set; }
        public string Prescription { get; set; }
    }
}

