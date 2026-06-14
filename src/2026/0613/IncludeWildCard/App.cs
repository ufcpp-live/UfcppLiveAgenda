#!

// 同一フォルダー内に A.cs, B.cs, C.cs がいる。
// それを全部取り込み。
#:include *.cs

// そのうち、C.cs だけ除外。
#:exclude C.cs

// ↓相当。
// <Compile Include="*.cs" />
// <Compile Remove="C.cs" />

// この2個は OK。
Console.WriteLine(A.Name);
Console.WriteLine(B.Name);

// C.cs は除外されているのでコンパイルエラー。
//Console.WriteLine(C.Name);
