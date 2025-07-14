namespace SimpleKTStudent.Domain.Model.Enums;

public enum TestingState
{
    /// <summary>
    /// Назначен студенту (начальное состояние).
    /// </summary>
    Assigned,
    /// <summary>
    /// В процессе прохождения.
    /// </summary>
    InProcess,
    /// <summary>
    /// Отменен.
    /// </summary>
    Cancelled,
    /// <summary>
    /// Завершен.
    /// </summary>
    Completed
}
