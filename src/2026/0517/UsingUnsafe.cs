#!/usr/bin/env dotnet
#:property LangVersion=Preview
#:property AllowUnsafeBlocks=true

// 「ポインターを使うだけなら safe」になったことで…

// int* 自体には unsafe を求めなくなっており、using unsafe 構文が(C# 12 で入れたばっかりだけどさっそく)無用の長物に。
using unsafe P1 = int*;

// 別にこれだけで良くなった。
using P2 = int*;

int x = 1;

int* p0 = &x; // これが unsafe 不要になってるので…

// この辺りにも unsafe 不要。
P1 p1 = &x;
P2 p2 = &x;
