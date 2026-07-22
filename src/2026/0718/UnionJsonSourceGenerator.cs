using System.Text.Json;
using System.Text.Json.Serialization;

// Source Generator にも対応。
// これ付けてコンパイルして IDE 上で参照を検索すればコード生成結果ものぞける。
// 気になる方は MyJsonContext.g.cs とか MyJsonContext.GetJsonTypeInfo.g.cs とかをのぞいてみるとよいかと。
[JsonSerializable(typeof(X))]
partial class MyJsonContext : JsonSerializerContext
{
}

union X(string, Base);

[JsonDerivedType(typeof(A), "A")]
[JsonDerivedType(typeof(B), "B")]
closed record Base;
record A : Base;
record B : Base;
