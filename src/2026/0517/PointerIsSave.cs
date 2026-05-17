#!/usr/bin/env dotnet

// ポインター使うだけだと safe。dereference だけが unsafe。

#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

int x = 0;

// ポインターを使うだけだと unsafe にならない。
static void M(int* _) { }

// アドレス取るのも平気。
M(&x);
int* p = &x;

// dereference した時点で unsafe コンテキストを要求。
// (この行だけコンパイルエラー起こす。unsafe {} でくくると解消。)
*p = 1;
