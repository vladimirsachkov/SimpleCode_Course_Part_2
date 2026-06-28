using System.Diagnostics;

namespace SimpleCode_Course_Part_2;


/// <summary>
/// Cобытия (Events) в C#
/// | Проблемы Инкапсуляции и Делегаты
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | #89
/// </summary>
public class Lesson_89
{
    delegate void Notify(string message);
    
    public static void Start()
    {
        Start_1();
    }

    public static void Start_1()
    {
        Notify notify = sendSMS;
        notify += sendEmail;

        notify("Hello World!");
    }

    static void sendSMS(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
    
    static void sendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}