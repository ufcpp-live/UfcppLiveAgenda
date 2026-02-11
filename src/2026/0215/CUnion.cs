using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine(Unsafe.SizeOf<CUnion>());

// 今のところ CStruct と CUnion しか対応してなさそう。
// (Swift レイアウトがない。)
// CUnion、名前通り C 言語の union ライクなレイアウト。
// 今までも StructLayout(Explicit) かつ FieldOffset(0) で一応同じことはできてたやつ。
// sizeof(CUnion) は 4。
[ExtendedLayout(ExtendedLayoutKind.CUnion)]
struct CUnion
{
    public int I;
    public float F;
    public byte B;
}
