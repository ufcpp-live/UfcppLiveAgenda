#!/usr/bin/env dotnet

// この LangVersion=Preview は app1.cs に1個書けば大丈夫みたい。
// U.cs とかでも preview 機能使えてる。
#:property LangVersion=Preview

// File-based アプリを複数ファイルに分けて書きたい場合、
// 取り込みたいファイルを #:include で明示する路線にするっぽい？
// (現時点で experimental なので迷ってそう。)
//
// experimental のうちは、 include を使うのにこのプロパティが必要。
// experimental だからって… 何この長さ…
#:property ExperimentalFileBasedProgramEnableIncludeDirective=true

// この行(UnionAttribute 型とかを定義したファイル)、ちゃんと U.cs のコンパイルでも参照されてる。
// .csproj に <Compile Include="Polyfill.cs" /> と書いてるのと同じ処理っぽい。
#:include Polyfill.cs

#:include U.cs
#:include DU.cs

Console.WriteLine(M(default));
Console.WriteLine(M(""));
Console.WriteLine(M(new Uri("http://a")));

Console.WriteLine(M1(default));
Console.WriteLine(M1(1));
Console.WriteLine(M1(DateOnly.FromDayNumber(1)));
Console.WriteLine(M1(TimeOnly.FromTimeSpan(TimeSpan.FromTicks(1))));

static int M(U u) => u switch
{
    string => 5,
    Uri => 7,
    null => 0, // .NET 11 Preview 2 時点、これがないと、switch 式が non-exhaustive になる仕様。叩かれてて変わりそう。
};

static int M1(DU u) => u switch
{
    int => 5,
    DateOnly => 7,
    TimeOnly => 11,
    null => 0, // .NET 11 Preview 2 時点、これがないと、switch 式が non-exhaustive になる仕様。叩かれてて変わりそう。
};
