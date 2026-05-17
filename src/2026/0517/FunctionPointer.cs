#!/usr/bin/env dotnet

// 関数ポインターも呼び出しだけが unsafe。

#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

static int M(int x) => x;

delegate*<int, int> f; // safe
f = &M; // safe

f(1); // ここで初めて unsafe コンテキストを要求。
