#!/usr/bin/env dotnet
#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

// dereference しない限りポインターも safe ということは、
// ローカル変数のアドレス取ったり、差を取ったりは safe。

int x = 0;
int y = 0;
int* px = &x;
int* py = &y;
Console.WriteLine((nint)(py - px));
