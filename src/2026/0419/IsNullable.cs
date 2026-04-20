// 値型 T に対して「is T?」とは書けない。

// object? に Nullable<T> のボックス化インスタンスが入ってること絶対にない(null or T のインスタンスのどっちか)ので。
// null には型はないし。
// is T? を is null or T の意味にはしなかった。単にエラーに。

U1 x1 = null;
Console.WriteLine(x1 is string); // これは x1.TryGetValue(out string? x) になってる。
Console.WriteLine(x1 is int); // x1.Value is int になってる。TryGetValue(out int?) は呼ばれない。
Console.WriteLine(x1 is int?); // これはエラーになるくせに

[Union]
struct U1
{
    public object? Value { get; }
    public U1(int x) { }
    public U1(string x) { }
    public bool TryGetValue(out int? x) { x = 0; return true; } // ここエラーにはならず、そのうえで絶対呼ばれない。
    public bool TryGetValue(out string? x) { x = null!; return true; } // こっちは呼ばれてる。
}
