using System.Collections;
using SimpleCode_Course_Part_2;

namespace Lesson85;

public class NumberSequence : IEnumerable<int>
{
    private readonly int _start;
    private readonly int _count;

    public NumberSequence(int start, int count)
    {
        _start = start;
        _count = count;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new NumberEnumerator(_start, _count);
    }

    /// <summary>
    /// Нужен для обратной совместимости
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}