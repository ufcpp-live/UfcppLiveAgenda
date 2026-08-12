#!

// generic な Complext<T> 追加。
// where T : IFloatingPointIeee754<T>, IMinMaxValue<T> で使える。
// (参考: 既存の non-generic Complex は double 実装。)

using System.Numerics;

// まあ確かに、「実数の Atan2 が使えれば虚数の Log を実装できる」みたいなのがあるので、
// IFloatingPointIeee754 制約あれが複素数の generic 実装は普通にできる。

var x = Complex<Decimal64>.Log(Complex<Decimal64>.ImaginaryOne);
Console.WriteLine(x);

Console.WriteLine(Decimal64.Atan2(1, 0));

Console.WriteLine(Decimal64.Pi / 2);
