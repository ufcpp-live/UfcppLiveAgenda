#!
#:property ExperimentalFileBasedProgramEnableRefDirective=true
#:property LangVersion=preview
#:property AllowUnsafeBlocks=true
#:ref UnsafeLib.cs

// updated-memory-safety-rules は立ててない(旧ルール下)。

// 呼べる。(updated-memory-safety-rules 立てると呼べなくなる。)
Lib.Unsafe();

// 呼べる。相手側が新ルール下の「safe」なので、こっち側に unsafe ブロック要らないらしい。
Lib.Safe(null);

// updated-memory-safety-rules は立ててない(旧ルール)内で定義されてるメソッドの場合、
// 「ポインターを含んでるだけでも unsafe ブロック必須」にするらしい。
// (updated-memory-safety-rules を立てると unsafe ブロック要らなくなる。)
unsafe
{
    Internal.A();
    Internal.B(null);
}

static class Internal
{
    // LangVersion 15 (今は Preview) で、ポインターを使っただけでは直ちに unsafe にはならなくなったけども…
    public static int* A() => null;
    public static void B(int* x){}
}
