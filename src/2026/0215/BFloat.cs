using System.Numerics;
using System.Runtime.CompilerServices;

// 15 = 1111 (2進数)
// 浮動小数点の類は「先頭1ビットは暗黙的に1」みたいなルールで1ビット削れるので、 111 が並んでる場所から後ろが仮数部。

float f32 = 15;
var f16 = (Half)15;
var bf16 = (BFloat16)15;

Console.WriteLine($"{Unsafe.As<float, uint>(ref f32):b32}");
Console.WriteLine($"{Unsafe.As<Half, ushort>(ref f16):b16}");
Console.WriteLine($"{Unsafe.As<BFloat16, ushort>(ref bf16):b16}");
