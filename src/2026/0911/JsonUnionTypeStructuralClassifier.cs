#!

using System.Text.Json;
using System.Text.Json.Serialization;

var x = JsonSerializer.Deserialize<U>("""{"Name":"abc"}""");

Console.WriteLine(x.Value); // B

// デフォルトだと JsonToken だけ見て型を判定する。
// 1 と "" は区別がつくけど、{} になるもの(record とか) が複数あると {} をデシリアライズできない。
//
// JsonUnionTypeStructuralClassifier を渡すと、{} の中身を見て判定してくれるようになるみたい。
// この場合 {"Value":0} と {"Name":""} をそれぞれ A, B でデシリアライズしてくれる。
[JsonUnion(TypeClassifier = typeof(JsonUnionTypeStructuralClassifier))]
union U(int, string, A, B);

record A(int Value);
record B(string Name);

// ちなみに、
// ↓は "X", "Y" が入ってれば弁別可能。{"Name":""} だけだとエラー。
//record A(string Name, int X);
//record B(string Name, string Y);
//
// ↓は {"X":0} と {"X":""} では弁別できない。
//record A(int X);
//record B(string X);
