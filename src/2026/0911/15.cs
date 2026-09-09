#!

// file-based app の言語バージョンが C# 15 になってる(.NET 11 で動かすならデフォルトが 15)。
// #:property 書かなくても union とか使えるようになってる。

// 以下、with, union, closed 辺りでデモ。

HashSet<string> hs = [with(StringComparer.OrdinalIgnoreCase), "A", "B", "C"];
Console.WriteLine(hs.Contains("a"));

static void M1(U u)
{
    Console.WriteLine(u switch
    {
        int i => $"int: {i}",
        string s => $"string: {s}",
    });
}
M1(1);
M1("hello");

static void M2(C c)
{
    Console.WriteLine(c switch
    {
        C1 c1 => "C1",
        C2 c2 => "C2",
    });
}
M2(new C1());
M2(new C2());


union U(int, string);

closed class C;
class C1 : C;
class C2 : C;
