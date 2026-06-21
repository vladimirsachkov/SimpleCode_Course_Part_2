using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson81;

[MemoryDiagnoser]
[ShortRunJob]
public class Benchmark_1
{
    
    [Benchmark]
    public void StructTest()
    {
        StructPoint point = new StructPoint();
        point.X = 1;
        point.Y = 1;
        var result = point.X = point.Y;
    }
    
    [Benchmark]
    public void ClassTest()
    {
        ClassPoint point = new ClassPoint();
        point.X = 1;
        point.Y = 1;
        var result = point.X = point.Y;
    }
}