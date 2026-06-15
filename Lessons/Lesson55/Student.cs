namespace SimpleCode_Course_Part_2;

public class Student
{
    public Guid id;
    public string firstName;
    public string lastName;
    public string middleName;
    public int age;
    public string group;

    public void Print()
    {
        Console.WriteLine("Информация об студенте");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Фамилия: {firstName}");
        Console.WriteLine($"Имя: {middleName}");
        Console.WriteLine($"Отчество: {lastName}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Группа: {group}");
    }

    public string GetFullName()
    {
        return $"{lastName} {firstName} {middleName}";
    }
}