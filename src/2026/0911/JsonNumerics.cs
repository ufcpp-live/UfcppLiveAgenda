#!

using System.Numerics;
using System.Text.Json;

var json = JsonSerializer.Serialize(new X((BFloat16)1, (Decimal32)2, 3, 4));
Console.WriteLine(json); // 先月まではここで実行時エラー。

var x = JsonSerializer.Deserialize<X>(json);
Console.WriteLine(x);

record struct X(BFloat16 A, Decimal32 B, Decimal64 C, Decimal128 D);
