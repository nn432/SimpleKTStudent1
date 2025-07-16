namespace SimpleKTStudent.API.DTOs.Testing
{
    public class StartTestingDto
    {
        public Guid TestingId { get; set; }
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
    }
}
