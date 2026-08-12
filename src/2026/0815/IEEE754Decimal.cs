#!
using System.Numerics;
using System.Text.Json;

// IEEE 754 規格準拠の10進浮動小数点数3種追加。
// C# の decimal は規格策定よりも前からある実装なのでケタ数とかが違う。
// C# で閉じてる分にはそれでもいいけど、バイナリで他環境とやり取りするなら規格に沿ったやつが欲しく。

Decimal32 x32 = (short)1;
Decimal64 x64 = 1;
Decimal128 x128 = 1;

// ちなみに、ケタ数減りかねない方向の変換には暗黙的変換は用意されてない。
Decimal32 x32_2 = (Decimal32)1; // = 1 だけにするとエラー。
Decimal64 x64_2 = (Decimal64)1.0; // = 1.0 だけにするとエラー。

// ちなみに、Preview 7 時点では JsonSerializer は未対応。
// 作業履歴を見てるに、RC 1 で対応予定。
var json = JsonSerializer.Serialize(x64);

// Preview 7 だと {} になっちゃう。
// (AOT 環境では「Reflection-based なシリアライズできない」例外が出る。)
Console.WriteLine(json);
