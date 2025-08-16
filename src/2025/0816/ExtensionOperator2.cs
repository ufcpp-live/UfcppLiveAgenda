#:property LangVersion=preview

var t = TimeSpan.FromMinutes(1);
t += 1;

Console.WriteLine(t);

Console.WriteLine("abc" * 3);

static class Ex
{
    extension(string)
    {
        public static string operator *(string s, int repeat)
            => string.Create(s.Length * repeat,
                (s, repeat),
                (span, state) =>
                {
                    var (str, rep) = state;
                    for (int i = 0; i < rep; i++)
                    {
                        str.AsSpan().CopyTo(span);
                        span = span[str.Length..];
                        // span.cs 参照:
                        // span += str.Length;
                    }
                });
                // Enumerable.Repeat(s, repeat).Aggregate((a, b) => a + b);
    }

    extension(ref TimeSpan ts)
    {
        public void operator +=(int x) => ts = ts.Add(TimeSpan.FromMinutes(x));
    }
}
