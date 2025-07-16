namespace SimpleKTStudent.API.DTOs.Testing
{
    public class FinishTestingDto
    {
        public Guid TestingId { get; set; }
        public DateTime EndTime { get; set; } = DateTime.UtcNow;
    }
}
