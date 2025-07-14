namespace SimpleKTStudent.Domain.Model.ValueObjects;
/// <summary>
/// Информация о конечных точках.
/// </summary>
public class EndPoints
{
    /// <summary>
    /// Конечная точка микросервиса конфигурации теста, 
    /// по которой можно получить конкретно взятый тест с конретной конфигурацией.
    /// </summary>
    public string GetTestEndPoint { get; set; } = string.Empty;
    /// <summary>
    /// Конечная точка по которой можно отправить результаты тестирования.
    /// </summary>
    public string SetResultTestEndPoint {  get; set; } = string.Empty;

}
