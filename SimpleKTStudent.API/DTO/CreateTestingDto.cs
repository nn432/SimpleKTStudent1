namespace SimpleKTStudent.API.DTOs.Testing
{
    public class CreateTestingDto
    {
        public string Name { get; set; }
        public Guid TestId { get; set; }
        public Guid ConfigId { get; set; }
        public Guid StudentId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
