using System.Collections;

int x = 0;

// with で required プロパティも set できない？
// (という案を出す人はいる。そんなに👍は多くない。)
A a = [with([1, 2, 3, ]) { X = 1, Y = 2, }, x = 1, 2, 3];

class A(params Span<int> p) : IEnumerable<int>
{
    public required int X { get; init; }
    public required int Y { get; init; }

    public void Add(int _) { }
    public IEnumerator<int> GetEnumerator() => throw new NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
