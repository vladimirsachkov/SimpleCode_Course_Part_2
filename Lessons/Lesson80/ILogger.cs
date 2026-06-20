namespace Lesson80;

public interface ILogger
{
    void Log(LogLevel level, string message);

    void LogError(string message)
    {
        Log(LogLevel.Debug, message);
    }
    
    void Foo()
    {
        Console.WriteLine("Test");
    }

    void Bar()
    {
        Console.WriteLine("Bar");
    }
}