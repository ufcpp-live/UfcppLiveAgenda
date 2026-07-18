#!
#:property LangVersion=preview

// JsonSerializer が union に対応。
// $type とかを入れるわけではなく、JsonTokenType か何かで判定してそう。

using System.Text.Json;

var json1 = JsonSerializer.Serialize(1); // 1
var jsonA = JsonSerializer.Serialize("A"); // "A"

// ↑ちなみに、 Serialize(new X(1)) とかにしても結果は「1」と「"A"」。

var x = JsonSerializer.Deserialize<X>(json1);
var y = JsonSerializer.Deserialize<X>(jsonA);

Console.WriteLine(x.Value); // int の 1 になってる。
Console.WriteLine(y.Value); // string の "A" になってる。

union X(int, string);
