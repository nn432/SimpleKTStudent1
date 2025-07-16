namespace SimpleKTStudent.API.DTOs.Testing
{
    public class TestingResultDto
    {
        public Guid TestingId { get; set; }
        public string StudentName { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
    }
}
