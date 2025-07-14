using SimpleKTStudent.Domain.Model.Enums;
using SimpleKTStudent.Domain.Model.ValueObjects;

namespace SimpleKTStudent.Domain.Model;
/// <summary>
/// Тест, назначенный конкретному студенту.
/// </summary>
public class Testing
{
    public Guid Id { get; set; }
    /// <summary>
    /// Название теста.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Идентификатор теста, экземпляром которого является Testing.
    /// </summary>
    public Guid TestId { get; set; }
    /// <summary>
    /// Идентификатор конфигурации теста (параметров теста).
    /// </summary>
    public Guid ConfigId { get; set; }
    /// <summary>
    /// Информация о конечных точках
    /// </summary>
    public EndPoints EndPoints { get; set; } = new EndPoints();
    /// <summary>
    /// Состояние теста, назначенного конкретному студенту.
    /// </summary>
    public TestingState TestingState { get; set; }
    /// <summary>
    /// Студент, которому назначен тест.
    /// </summary>
    public Student Student { get; set; } = new Student();
    /// <summary>
    /// Время начала прохождения теста.
    /// </summary>
    public DateTime TestingBegin { get; set; }
    /// <summary>
    /// Время завершения прохождения теста.
    /// </summary>
    public DateTime TestingEnd { get; set; }
    /// <summary>
    /// Начало временной вилки прохождения теста.
    /// </summary>
    public DateTime Begin { get; set; }
    /// <summary>
    /// Окончание временной вилки прохождения теста.
    /// </summary>
    public DateTime End { get; set; }
    /// <summary>
    /// Результаты тестирования.
    /// </summary>
    public TestingResults Results { get; set; } = new TestingResults();
}
