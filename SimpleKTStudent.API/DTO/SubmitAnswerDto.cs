namespace SimpleKTStudent.API.DTOs.Testing
{
    public class SubmitAnswerDto
    {
        public Guid TestingId { get; set; }
        public string QuestionId { get; set; }
        public string Answer { get; set; }
    }
}
