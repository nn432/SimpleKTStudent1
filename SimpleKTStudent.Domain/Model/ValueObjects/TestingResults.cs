namespace SimpleKTStudent.Domain.Model.ValueObjects;
/// <summary>
/// 
/// </summary>
public class TestingResults
{
    /// <summary>
    /// Число тестовых вопросов в попытке.
    /// </summary>
    public int QuestionCount { get; set; }
    /// <summary>
    /// Число сделанных попыток.
    /// </summary>
    public int AttempCount { get; set; }
    /// <summary>
    /// Средне-арифметическое число правильных ответов.
    /// </summary>
    public int AverageCorrectAnswersCount { get; set; }
    /// <summary>
    /// Средне-арифметический процент правильных ответов.
    /// </summary>
    public double AverageCorrectAnswersPercent { get; set; }
    /// <summary>
    /// Максимальное число правильных ответов в попытках.
    /// </summary>
    public int BestCorrectAnswersCount { get; set; }
    /// <summary>
    /// Максимальный процент правильных ответов в попытках.
    /// </summary>
    public double BestCorrectAnswersPercent { get; set; }
    /// <summary>
    /// Тест зачтен (true) / не зачтен (false).
    /// </summary>
    public bool Checked { get; set; } = false;
}
