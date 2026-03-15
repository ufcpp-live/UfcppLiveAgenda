// 拡張インデクサーが絡む版。
// どっちが優先？

var s = new S();
_ = s[1];
_ = s[^1]; // インスタンスの this[Length - 1] ? それとも 拡張の this[Index] ?

// LDM の結論: インスタンス優先
// Range オーバーロード(s[i..j] → Slice )も同様。

static class Ex
{
    extension(S x)
    {
        // C# 15 案
        public int this[Index index] => x * index.Value;
    }
}

public struct S
{
    public int this[int index] => index * 2;
    public int Length => 10;
}


