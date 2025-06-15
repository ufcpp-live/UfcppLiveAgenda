#!/usr/bin/env dotnet
// ↑この行は適当。
// Copilot さん提案でそのまま受け入れ。
// 後で聞いた感じ、 dotnet-run とか -S dotnet run でないとダメっぽい。

// csproj でいう PropertyGroup 内のタグ相当。
#:property LangVersion preview

Console.WriteLine("🐈");

record struct X(int A);

class Y
{
    public int X { set => field = value; }
}
