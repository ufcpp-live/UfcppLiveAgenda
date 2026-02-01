IReadOnlyList<int> x = [1, 2, 3];

Console.WriteLine(x is int[]); // false
Console.WriteLine(x.GetType().Name); // compiler generated type

static void M(IEnumerable<int> x)
{
    if (x is int[] a)
    {
        // M([]); はここに来ない。

        // ...
        a[0] = 1; // できちゃう…
    }

    if (x is List<int> b)
    {
        // M([]); はここに来ない。
    }
}
