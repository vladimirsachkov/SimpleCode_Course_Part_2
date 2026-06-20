namespace Lesson74;

public class B : A
{
    public B()
    {
        Console.WriteLine(publicFiled); // Поле доступно
        // Console.WriteLine(privateFiled); // Поле недоступно
        Console.WriteLine(protectedFiled); // Поле доступно
    }
}