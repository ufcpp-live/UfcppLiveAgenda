// OutputType=Library を付けとけばちゃんとライブラリとしてビルドされる。
// dotnet pack Lib.cs ってコマンドで artifacts/Lib/Lib.dll ができる。

#:property OutputType=Library

public class Lib
{
    public static string Name => "Lib";
}
