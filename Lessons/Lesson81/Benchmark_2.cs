using BenchmarkDotNet.Attributes;

namespace Lesson81;
[MemoryDiagnoser]
public class Benchmark_2
{
    
    [Benchmark]
    public void StructAreTest()
    {
        StructPoint[] structPoints = new StructPoint[100];
        for (int i = 0; i < structPoints.Length; i++)
        {
            structPoints[i] = new StructPoint();
        }
    }
    
    [Benchmark]
    public void ClassAreTest()
    {
        ClassPoint[] classPoint = new ClassPoint[100];
        for (int i = 0; i < classPoint.Length; i++)
        {
            classPoint[i] = new ClassPoint();
        }
    }
}