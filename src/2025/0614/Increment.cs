// see also: CompoundPlus.cs

// .NET 10 Preview 5 のリリースドキュメントには書かれてなかったけど、
// ++も「インスタンスメソッドとして実装可能」という仕様が同時に入ってる。

#:property LangVersion preview

var x = new X(1);
++x;
x++; // これはいいけど、
var y = x++; // これはダメっぽい。(struct でもダメ。勝手にコピーはしない。)
var z = ++x; // これもいい。

Console.WriteLine(x.Value);
//Console.WriteLine(y.Value);
Console.WriteLine(z.Value);

class X(int value)
{
    public int Value { get; private set; } = value;

    // ++ -- も入ってそう。
    public void operator ++() => Value += 1;

    // インスタンスの方が優先されてそうな雰囲気。
    // インスタンス ++ 追加は一応 breaking change かな。
    //public static X operator ++(X x) => new(x.Value - 1); // わざと変。
}
