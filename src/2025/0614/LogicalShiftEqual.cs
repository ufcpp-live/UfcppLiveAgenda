// see also: CompoundPlus.cs

// 復号代入の中でひときわ目立つ >>>=

#:property LangVersion preview

var x = new X(0x100);
x >>>= 2;

Console.WriteLine(x.Value);

class X(int value)
{
    public int Value { get; private set; } = value;

    // > の個数間違いそう…
    public void operator >>>=(int value) => Value >>>= value;
}
