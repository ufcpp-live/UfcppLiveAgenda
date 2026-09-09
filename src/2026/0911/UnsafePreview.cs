#!

// ※1 の辺りをコンパイルするにはこの行が必要。
#:property LangVersion=preview

// ※2 の辺り関連。
#:property AllowUnsafeBlocks=true
#:property Features=$(Features);updated-memory-safety-rules

// ※1
// (おそらく来年) 「ポインター型を使うだけなら safe」になる予定。
// これはフィーチャーフラグみたいなのなしで無条件にそうなる予定。
// ただ、この機能は .NET 11/C# 15 では「preview のままにする」という判断に。

// #:property LangVersion=preview がないとこの行はエラーになる。
int* p = null;

// ※2
// updated-memory-safety-rules フィーチャーフラグを付けたとき、
// 「ポインター使ってなくても unsafe を求める」判定あり。

// この行はエラーになる予定だけど、LangVersion=preview (おそらく来年、LangVersion=16)だけではそうならない。
C.M();

unsafe
{
    // これならコンパイルできる。
    C.M();
}

class C
{
    public static unsafe void M() { }
}
