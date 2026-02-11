using System.Runtime.CompilerServices;
// CStruct はよくわからない…
using System.Runtime.InteropServices;

Console.WriteLine(Unsafe.SizeOf<Sequential>());
Console.WriteLine(Unsafe.SizeOf<CStruct>());

struct Sequential
{
    public byte A;
    public int B;
    public long C;
    public byte D;
}

[ExtendedLayout(ExtendedLayoutKind.CStruct)]
struct CStruct
{
    public byte A;
    public int B;
    public long C;
    public byte D;
}

// .NET の Sequential レイアウトとの差がわからない…

// CStruct 対応の pull request を覗いてみて、空の CStruct は許可されていないというのだけは把握。
// この型を参照すると runtime エラーでアプリ異常終了するようになる。
[ExtendedLayout(ExtendedLayoutKind.CStruct)]
struct CStructEmpty
{
}
