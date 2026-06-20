namespace Lesson74;

public class A
{
    public int publicFiled;
    private int privateFiled;
    private protected int protectedFiled;

    public A()
    {
        Console.WriteLine(publicFiled); // поле доступно
        Console.WriteLine(privateFiled); // поле доступно
        Console.WriteLine(protectedFiled); // поле доступно
    }
    
    public void Foo()
    {
        Console.WriteLine(publicFiled); // поле доступно
        Console.WriteLine(privateFiled); // поле доступно
        Console.WriteLine(protectedFiled); // поле доступно
    }
}