namespace Lesson71;

public class Person
{
    public int a;
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"Меня зовут {FirstName}");
    }
}