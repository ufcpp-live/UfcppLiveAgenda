#:property LangVersion=preview

Span<int> numbers = [1, 2, 3, 4];

for (var it = numbers; it; ++it)
{
    Console.WriteLine(it[0]);
}

static class Ex
{
    extension<T>(ref Span<T> span)
    {
        public void operator ++() => span = span[1..];
        public void operator +=(int length) => span = span[length..];
        public static bool operator true(Span<T> x) => x.Length != 0;
        public static bool operator false(Span<T> x) => x.Length == 0;
    }
}
