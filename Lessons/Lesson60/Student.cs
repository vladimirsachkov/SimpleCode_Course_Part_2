namespace SimpleCode_Course_Part_2.Lesson60;

public class Student
{
    public Student(string lastName, DateTime birthDate)
    {
        lastName = lastName;
        this.birthDate = birthDate;
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate) : this(lastName, birthDate)
    {
        this.firstName = firstName;
        this.middleName = middleName;
    }

    public Student(Student student)
    {
        this.firstName = student.firstName;
        this.middleName = student.middleName;
        this.lastName = student.lastName;
        this.birthDate = student.birthDate;
    }

    private string firstName;
    private string middleName;
    private string lastName;
    private DateTime birthDate;

    public void Print()
    {
        Console.WriteLine($"Имя: {firstName}\n " +
                          $"Фамилия: {lastName}\n " +
                          $"Отчество: {middleName}\n " +
                          $"Дата Рождения: {birthDate}");
    }
    
    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }
}