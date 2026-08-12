#!

using System.Runtime.CompilerServices;

ref InlineArray10<byte> s = ref Unsafe.NullRef<InlineArray10<byte>>();

// 前までこの辺りが実行時エラーにならなかったらしい(参照は未定義動作)。
// NullReferenceException が出るように修正(LangVersion 14 に対しても修正)。
ref var r = ref s[0];
Span<byte> span = s;
