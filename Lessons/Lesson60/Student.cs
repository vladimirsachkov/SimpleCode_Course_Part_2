namespace SimpleCode_Course_Part_2.Lesson60;

public class Student
{
    public Student(string lastName, DateTime birthDate)
    {
        _lastName = lastName;
        _birthDate = birthDate;
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate)
    {
        _firstName = firstName;
        _middleName = middleName;
        _lastName = lastName;
        _birthDate = birthDate;
    }

    public Student(Student student)
    {
        _firstName = student._firstName;
        _middleName = student._middleName;
        _lastName = student._lastName;
        _birthDate = student._birthDate;
    }

    private string _firstName;
    private string _middleName;
    private string _lastName;
    private DateTime _birthDate;

    public void Print()
    {
        Console.WriteLine($"Имя: {_firstName}\n " +
                          $"Фамилия: {_lastName}\n " +
                          $"Отчество: {_middleName}\n " +
                          $"Дата Рождения: {_birthDate}");
    }
    
    public void SetLastName(string lastName)
    {
        this._lastName = lastName;
    }
}