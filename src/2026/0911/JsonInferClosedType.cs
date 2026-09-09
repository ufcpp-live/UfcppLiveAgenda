#!

using System.Text.Json;
using System.Text.Json.Serialization;

// 先月までは JsonSerializerOptions の指定が必須だった。
// var opt = new JsonSerializerOptions { InferClosedTypePolymorphism = true };

Base x = new A("abc");

var json = JsonSerializer.Serialize(x);
Console.WriteLine(json);

var y = JsonSerializer.Deserialize<Base>(json);
Console.WriteLine(y);

// 型定義側に属性で InferClosedTypePolymorphism 指定する手段も提供。
[JsonPolymorphic(InferClosedTypePolymorphism = true)]
closed record Base;
record A(string S) : Base;
record B : Base;
