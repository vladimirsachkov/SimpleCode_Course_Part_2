namespace Lesson_68_class;

partial class Person
{
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public partial void PrintFullName()
    {
        Console.WriteLine(GetFullName());
    }
}