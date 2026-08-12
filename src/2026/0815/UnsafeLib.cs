#!
#:property OutputType=Library
#:property Features=$(Features);updated-memory-safety-rules
#:property LangVersion=preview
#:property AllowUnsafeBlocks=true

public static class Lib
{
    // 新ルールオプション立ててるのでこれは caller unsafe の意味。
    public unsafe static void Unsafe(){}

    // 逆にこれは safe。
    public static void Safe(int* x){}
}
