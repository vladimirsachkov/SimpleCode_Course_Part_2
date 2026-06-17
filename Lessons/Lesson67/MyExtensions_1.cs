using Lesson67;

namespace Lesson_MyExtensions;

public static class MyExtensions_1
{
    public static string GetFullName(this Student student)
    {
        return student.LastName + " " + student.FirstName;
    }
}