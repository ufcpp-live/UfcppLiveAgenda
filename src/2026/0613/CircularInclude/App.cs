#!

// このファイルが A.cs を、A.cs が B.cs を、B.cs がこのファイルを、と循環 includeしてみる。
#:include A.cs

// 今のところ全然平気。
// 確かに「重複した include」はないけども…

Console.Write(A.Name);
Console.Write(B.Name);
Console.Write(C.Name);

class C
{
    public static string Name => "C";
}
