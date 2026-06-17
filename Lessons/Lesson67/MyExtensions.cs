namespace Lesson_MyExtensions;

static class MyExtensions
{
    public static void Print(this DateTime dateTime)
    {
        Console.WriteLine(dateTime);
    }

    public static bool isDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
    {
        return dateTime.DayOfWeek == dayOfWeek;
    }
}