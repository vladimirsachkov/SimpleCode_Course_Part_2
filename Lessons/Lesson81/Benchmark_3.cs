using BenchmarkDotNet.Attributes;

namespace Lesson81;

[MemoryDiagnoser]
public class Benchmark_3
{
    private MyStruct _myStruct = new MyStruct();
    private MyClass _myClass = new MyClass();
    
    [Benchmark]
    public void StructTest()
    {
        Bar(_myStruct);
    }
    
    [Benchmark]
    public void StructTestIn()
    {
        Bar(_myStruct);
    }
    
    [Benchmark]
    public void ClassTest()
    {
        Foo(_myClass);
    }
    
    private void Foo(Lesson81.MyClass myClass)
    {
        var t = myClass.MyProperty1 + myClass.MyProperty2;
    }
    
    private void Bar(Lesson81.MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }
    
    private void Bar(in Lesson81.MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }
}