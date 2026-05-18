#!/usr/bin/env dotnet
#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

// FunctionPointer.cs のコードを見せてるときに出た話題で、
// unsafe コンテキストがブロック {} でしか作れないのめんどくさいし、式を書きたいという流れに。

static int M(int x) => x;
delegate*<int, int> f; // safe
f = &M; // safe

var y1 = f(1); // ここで初めて unsafe コンテキストを要求(この書き方だとエラー)。

// こう書かなきゃいけないのめんどい…
int y2;
unsafe
{
    y2 = f(1);
}

// unsafe 式みたいな機能が欲しい。 () 付きでもいいので…
var y3 = unsafe(f(1));

// それか、unsafe operator?
var y4 = unsafe f(1);
