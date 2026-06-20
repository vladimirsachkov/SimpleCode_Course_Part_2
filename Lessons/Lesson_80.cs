namespace SimpleCode_Course_Part_2;
using Lesson80;

/// <summary>
/// Реализация интерфейса по умолчанию в C# 8.0
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 80 
/// </summary>
public class Lesson_80
{
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        ILogger consoleLogger = new ConsoleLogger();
        consoleLogger.Foo();
        consoleLogger.Log(LogLevel.Debug, "some event");
        consoleLogger.Log(LogLevel.Warning, "some warning");
        consoleLogger.Log(LogLevel.Fatal, "some fatal error");
        consoleLogger.Log(LogLevel.Error, "some error");
    }
}