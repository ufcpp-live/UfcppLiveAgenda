#!

// この2行は平気。 #: の前に define とか pragma は認められてる。
#define A
#pragma warning disable CS0162

#if DEBUG
// ここがダメ。コンパイルエラー。
// 条件コンパイル #: は認められない。
// そりゃまあ、csproj への変換で困る。
#:include A.cs
#endif

{}
