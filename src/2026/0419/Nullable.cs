// Nullable<T> のボックス化はむっちゃ特殊(.NET Runtime 側の特殊対応)という話。

int? x1 = 1;
object o1 = x1; // ここでボックス化しています

int? x2 = null;
object o2 = x2; // これ、別にボックス化しない。 o2 には null が入る。

Console.WriteLine(M<int>() is null); // false, box あり
Console.WriteLine(M<int?>() is null); // true, box なし。object に Nullable<int> がボックス化したものが入ったりはしない。

object? M<T>() => default(T);

// 現状、↑の特別扱いと同じ挙動はユーザー定義構造体では絶対にできない。
// 似た挙動を得るために、「ユーザー定義ボックス化」とかあればいいのになぁとか思わなくもない。
struct MyCustomUnion
{
    public object? Value { get; }

    // これができれば2重ボックス問題回避できるのになぁ…
    public static explicit operator object(MyCustomUnion c) => c.Value; // これ、ダメ。
}

// ただ、↓みたいな多段解決が多分だいぶ複雑すぎて、だいぶやりたくはないはず。
// (C# 言語レベルでは無理で、結局 Runtime 側対応が必要。)
union U1(int);
union U2(U1);
