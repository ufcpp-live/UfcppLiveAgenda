#!
using System.Text.Json;

var opt = new JsonSerializerOptions { InferClosedTypePolymorphism = true };

Base x = new A("abc");

// opt を渡してないと { "S": "abc" } だけになって、型情報が失われる。
var json = JsonSerializer.Serialize(x, opt);
Console.WriteLine(json);

// opt を渡してないとデシリアライズできない。
var y = JsonSerializer.Deserialize<Base>(json, opt);
Console.WriteLine(y);


closed record Base;
record A(string S) : Base;
record B : Base;

// RC 1 (来月)では [JsonPolymorphic] 属性にも InferClosedTypePolymorphism を足す予定っぽい。
// Base 側に指定しておけば、JsonSerializerOptions は不要に。
