// 現バージョンのインデクサーの挙動。

// インデクサーには「暗黙の呼び出しルール」がある。
// x[^i] は this[Index] が呼ばれるケースと this[int] で代用するケースの2パターンがある。

var s1 = new S1();
_ = s1[1];
_ = s1[^1]; // this[Index] が呼ばれてる

var s2 = new S2();
_ = s2[1];
_ = s2[^1]; // this[int] で代用するために this[s2.Length - 1] が呼ばれてる(暗黙的に変換がかかってる)

public struct S1
{
    public int this[Index index] => index.Value * 2;
}

public struct S2
{
    public int this[int index] => index * 2;
    public int Length => 10;
}


