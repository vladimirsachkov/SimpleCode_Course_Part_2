using BenchmarkDotNet.Attributes;

namespace Lesson84;

[MemoryDiagnoser]
public class SwapsBenchmark
{
    
    [Benchmark]
    public void GenericSwapBenchmark()
    {
        double a = 1; 
        double b = 5.3;
        SwapTestClass.GenericSwap(ref a, ref b);
    }
    
    [Benchmark]
    public void SwapBenchmark()
    {
        object p1 = 2; 
        object p2 = 4;
        SwapTestClass.GenericSwap(ref p1, ref p2);
    }
}