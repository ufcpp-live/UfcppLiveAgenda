using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 「union のボックス化する実装が嫌なら自作しろ」な例。
//
// 何を格納しているかの弁別用の値(discriminator) + StructLayout.Explicit を使った C-Union 的な実装。
// いわゆる discriminated union (判別共用体とか弁別共用体とか) と呼ばれるもの。
//
// こういうコードでも、手書きすれば u is int とかは使える。
// 実質、ユーザー定義 is 演算子 + exhaustivity チェック。
//
// この手のコード生成をするようなもの、C# に構文を足すのは、
// FieldOffset が「参照型を含んでるときの挙動が undocumented」すぎてちょっと難航しそうな予感はする。
// 全部が unmanaged な値型なら問題ないんだけども。
//
// union struct(int, DateOnly, TimeOnly) みたいな構文でこういう実装するかも？みたいな話はなくはない。
// (record に後から record struct を足したみたいに、あとからでも大丈夫だろうと。)
//
// 他に、「拡張 enum」として、
// enum { X(int), Y(DateOnly), Z(TimeOnly) }
// みたいな構文も提案はある。
[Union]
[StructLayout(LayoutKind.Explicit)]
readonly struct DU
{
    [FieldOffset(8)]
    private readonly byte _type;

    [FieldOffset(0)] private readonly int _x;
    [FieldOffset(0)] private readonly DateOnly _y;
    [FieldOffset(0)] private readonly TimeOnly _z;

    public DU(int x)
    {
        _x = x;
        _type = 1;
    }

    public DU(DateOnly y)
    {
        _y = y;
        _type = 2;
    }

    public DU(TimeOnly z)
    {
        _z = z;
        _type = 3;
    }

    public bool HasValue => _type != 0;

    public object? Value => _type switch
    {
        1 => _x,
        2 => _y,
        3 => _z,
        _ => null,
    };

    public bool TryGetValue(out int x)
    {
        if (_type == 1)
        {
            x = _x;
            return true;
        }
        x = default;
        return false;
    }

    public bool TryGetValue(out DateOnly y)
    {
        if (_type == 2)
        {
            y = _y;
            return true;
        }
        y = default;
        return false;
    }

    public bool TryGetValue(out TimeOnly z)
    {
        if (_type == 3)
        {
            z = _z;
            return true;
        }
        z = default;
        return false;
    }
}
