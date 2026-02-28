using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// long????? 相当コード、C# のレイアウト規則だと48バイトになる…
// アラインメント、パディングのせい。
Console.WriteLine(Unsafe.SizeOf<Optional<Optional<Optional<Optional<Optional<long>>>>>>());

struct Optional<T>
{
    public T Value;
    public bool HasValue;
}

// ↓これを付けたら size 13 になった。
// [StructLayout(LayoutKind.Sequential, Pack = 1)]
