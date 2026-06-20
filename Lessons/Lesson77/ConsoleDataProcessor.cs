namespace Lesson77;

public class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}