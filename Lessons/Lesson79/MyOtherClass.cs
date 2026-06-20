namespace Lesson79;

public class MyOtherClass : IFirstInterface, ISecondInterface
{
    void IFirstInterface.Action()
    {
        Console.WriteLine("MyOtherClass IFirstInterface.Action...");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("MyOtherClass ISecondInterface.Action...");
    }
}