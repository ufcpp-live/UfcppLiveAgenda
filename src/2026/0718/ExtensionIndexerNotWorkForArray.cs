#!
#:property LangVersion=preview

using System.Runtime.CompilerServices;

// 配列に対する拡張インデクサーは無理。呼ばれない(仕様)。
// this T[] だろうと this IEnumerable<T> だろうと、ReadOnlySpan<T> だろうと、どれもダメ。

string[] log = ["start", "work", "done"];

Console.WriteLine(log[MyIndex.A]); // ここでエラー。

ReadOnlyListExtensions.get_AnotherName(log, MyIndex.A);

static class ReadOnlyListExtensions
{
    extension<T>(ReadOnlySpan<T> list)
    {
        [IndexerName("AnotherName")]
        public T this[MyIndex index] => list[(int)index];
    }
}

enum MyIndex { A, B }

class C
{
    [IndexerName("AnotherName")]
    public int this[int i] => i;
}


