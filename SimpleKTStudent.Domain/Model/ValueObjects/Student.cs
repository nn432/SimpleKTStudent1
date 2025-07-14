namespace SimpleKTStudent.Domain.Model.ValueObjects;
/// <summary>
/// Основная информация о студенте, которому назначен тест.
/// </summary>
public class Student
{
    /// <summary>
    /// 
    /// </summary>
    public string FullName { get; set; } = string.Empty;
    /// <summary>
    /// /
    /// </summary>
    public Guid ObjectId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string Url { get; set; } = string.Empty;
}
