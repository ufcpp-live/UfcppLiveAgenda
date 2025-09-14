// primitive に対する sizeof は const 扱いになるので平気。
ushort x = sizeof(int);

unsafe
{
    // これ今、非 const な sizeof は確定で int 扱い。
    // int から implicit cast できない型相手にエラー。

    // size, length は native int であるべきじゃない？
    // Span.Length とかでも困る…
    nint y1 = sizeof(string);

    uint y2 = sizeof(string);
    ulong y3 = sizeof(string);
    ushort y4 = sizeof(string);
}
