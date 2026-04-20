// record も Union 属性付ければ TryGetValue でパターンマッチできる。

using System.Runtime.CompilerServices;

R x = new(1);

Console.WriteLine(x is int);
Console.WriteLine(x is string);

// この例では、「string 側が not null ならそれを、 null なら int 側を使う」実装。
[Union]
record R(int X, string? Y)
{
    public R(int x) : this(x, null) { }
    public R(string x) : this(0, x) { }

    public object? Value => Y is { } x ? x : X;

    public bool TryGetValue(out int x)
    {
        if (Y is null)
        {
            x = X;
            return true;

        }
        else
        {
            x = default;
            return false;
        }
    }

    public bool TryGetValue(out string x)
    {
        if (Y is { } y)
        {
            x = y;
            return true;

        }
        else
        {
            x = null!;
            return false;
        }
    }
}
