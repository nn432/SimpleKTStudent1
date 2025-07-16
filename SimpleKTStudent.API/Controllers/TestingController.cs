using Microsoft.AspNetCore.Mvc;
using SimpleKTStudent.API.DTOs.Testing;
using SimpleKTStudent.Domain.Interfaces.Repositories;
using SimpleKTStudent.Domain.Model;
using SimpleKTStudent.Domain.Model.Enums;

namespace SimpleKTStudent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestingController : ControllerBase
    {
        private readonly ITestingRepository _repository;

        public TestingController(ITestingRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateTestingDto dto)
        {
            var testing = new Testing
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                TestId = dto.TestId,
                ConfigId = dto.ConfigId,
                Begin = dto.Begin,
                End = dto.End,
                TestingState = TestingState.Assigned,
                Student = new Domain.Model.ValueObjects.Student { ObjectId = dto.StudentId },
                TestingBegin = DateTime.MinValue,
                TestingEnd = DateTime.MinValue
            };

            await _repository.AddAsync(testing);
            await _repository.SaveChangesAsync();

            return Ok(testing.Id);
        }

        [HttpPost("start/{id}")]
        public async Task<IActionResult> StartTest(Guid id)
        {
            var testing = await _repository.GetByIdAsync(id);
            if (testing == null)
                return NotFound();

            testing.TestingBegin = DateTime.UtcNow;
            testing.TestingState = TestingState.InProcess;

            await _repository.UpdateAsync(testing);
            await _repository.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("submit")]
        public async Task<IActionResult> SubmitAnswer([FromBody] SubmitAnswerDto dto)
        {
            var testing = await _repository.GetByIdAsync(dto.TestingId);
            if (testing == null)
                return NotFound();

            // Пример логики подсчёта результата (заглушка)
            // testing.Results.Answers.Add(new Domain.Model.ValueObjects.TestAnswer
            // {
            //     QuestionId = dto.QuestionId,
            //     Answer = dto.Answer
            // });

            await _repository.UpdateAsync(testing);
            await _repository.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("finish/{id}")]
        public async Task<IActionResult> Finish(Guid id)
        {
            var testing = await _repository.GetByIdAsync(id);
            if (testing == null)
                return NotFound();

            testing.TestingEnd = DateTime.UtcNow;
            testing.TestingState = TestingState.Completed;

            await _repository.UpdateAsync(testing);
            await _repository.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("result/{id}")]
        public async Task<ActionResult<TestingResultDto>> GetResult(Guid id)
        {
            var testing = await _repository.GetByIdAsync(id);
            if (testing == null)
                return NotFound();

            var result = new TestingResultDto
            {
                TestingId = testing.Id,
                StudentName = testing.Student.FullName,
                CorrectAnswers = testing.Results.NumberCorrectAnswers,
                TotalQuestions = testing.Results.QuestionCount,
                StartedAt = testing.TestingBegin,
                FinishedAt = testing.TestingEnd
            };

            return Ok(result);
        }
    }
}
