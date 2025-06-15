// see also: LangVersion9.cs
//
// もっとバージョン下げてみようってやってみたやつ。

#:property LangVersion 7

// まず「C# 7 で #nullable enable は使えないよ」エラーが出たのでこの行を追加。
#:property Nullable disable

// そしたら「global using はつ開けないよ」エラーも出たのでこの行も追加。
#:property ImplicitUsings disable

// 要するに、single-file 実行だとデフォルトで Nullable enable, ImplicitUsings enable なので、
// わざわざ disable なディレクティブを追加しないとコンパイルできない。
// (まあ、わざわざ C# 7 で書く理由もない。)

static class Program
{
    static void Main()
    {
        System.Console.WriteLine("🐈");
    }
}
