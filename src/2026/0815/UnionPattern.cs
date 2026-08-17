#!

// see: UnionPatternCancelled.cs

#:property LangVersion=preview

M(1);

static int M(X x) => x switch
{
    string => 1, // x.Value is string 相当
    X => 2, // x is X 相当
    // 前までこの x is と x.Value is の混在がダメだったっぽい。

    // ※ .NET 11 Preview 7 で一瞬この仕様が入ったものの、やっぱり取りやめに。
    // see: UnionPatternCancelled.cs
};

union X(string, int);
