#!

// ちゃんと Unsafe クラスの unsafe なメソッドに unsafe 修飾子付いたみたい。
// 「名前的に Unsafe のくせに unsafe コンテキスト不要で unsafe よりも unsafe」問題解消。
// safe unsafe。

#:property LangVersion=preview
#:property AllowUnsafeBlocks=true
#:property Features=$(Features);updated-memory-safety-rules

using System.Runtime.CompilerServices;

var x = 1;
Unsafe.Add(ref x, 1); // ちゃんとこれがコンパイルエラー。
