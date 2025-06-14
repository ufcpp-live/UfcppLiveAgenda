#!/usr/bin/env dotnet
#:property LangVersion preview

{
    var x = new X(1);
    x += 2;
    Console.WriteLine(x.Value);
}
{
    var x = new X(1);
    x = x + 2;
    Console.WriteLine(x.Value);
}

class X(int value)
{
    public int Value { get; private set; } = value;

    public void operator +=(int value) => Value += value;

    // 明らかにおかしい実装わざとやる
    public static X operator +(X x, int value) => new(x.Value - value);
}
