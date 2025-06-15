// .NET 10 Preview 5 で入った C# の新機能
// ユーザー定義の復号代入の例。

#:property LangVersion preview

var x = new X(1);
var y = x;
x += 2;

Console.WriteLine(x.Value);

Console.WriteLine(ReferenceEquals(x, y));

class X(int value)
{
    public int Value { get; private set; } = value;

    // こんなの。
    // クラスでも自己書き換えな演算子が書ける。
    // (ちなみに、両方あるときはこっち優先。)
    public void operator +=(int value) => Value += value;

    // こっちだと、new() されてるので別インスタンスが返る。
    public static X operator +(X x, int value)
    {
        return new X(x.Value + value);
    }
}
