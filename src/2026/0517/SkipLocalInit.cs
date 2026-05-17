#!/usr/bin/env dotnet

// 「未初期化メモリを読めそう」みたいな場面で unsafe コンテキストを求めるように。
// SkipLocalsInit と stackalloc を使うとありえる。

#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

[System.Runtime.CompilerServices.SkipLocalsInit]
void M()
{
    // ダメ。
    // (unsafe {} でくくると OK。)
    Span<int> a = stackalloc int[5];          // 未初期化メモリを読めることになるのでダメにしたんだって。

    // OK。
    Span<int> b = stackalloc int[] { 1, 2 };  // ちゃんと初期値を入れるなら OK。
    Span<int> c = stackalloc int[2] { 1, 2 }; // これも初期値与えてるから OK。
}
