using BenchmarkDotNet.Attributes;

namespace Lesson82;

[MemoryDiagnoser]
public class BoxingTest
{
    
    [Benchmark]
    public void NoBoxing()
    {
        int res = 0;
        int a = 1;
        res += a;
    }
    
    [Benchmark]
    public void Boxing()
    {
        int res = 0;
        int a = 1;
        res += a;
    }
}