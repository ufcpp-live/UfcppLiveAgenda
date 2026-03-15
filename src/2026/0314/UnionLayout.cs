// ref フィールドが絡むときの C Union 的な構造体レイアウト。

// ref と参照型(どっちも GC トラッキング対象のポインターではある)は重ねちゃダメらしい。
// (LayoutKind.Sequential であっても) 参照型と同じく 「ref フィールドは前に移動する」みたいなレイアウトにはなってそう。
// 「ref フィールドの数がそろってる」かつ「参照型フィールドの数がそろってる」という状況ならレイアウト重ねて問題なさそう。

using System.Runtime.InteropServices;

M();

static void M()
{
    X x = default;
}

[StructLayout(LayoutKind.Explicit)]
ref struct X
{
    [FieldOffset(0)]
    public S S;

    [FieldOffset(0)]
    public T T;
}

ref struct S
{
    public int Length;
    public ref byte Value;

    private object _dummy;
}

ref struct T
{
    public string Str;

    public ref byte Value;
    public int Length;
}

