#!
#:property LangVersion=preview

using System.Text.Json;

var jsonA = JsonSerializer.Serialize<X>("abc");
//var jsonA = JsonSerializer.Serialize<X>(new A(1));
//var jsonA = JsonSerializer.Serialize<X>(new B("abc"));

Console.WriteLine(jsonA);

// string になってると弁別可能。
// (Serialize<X>(new A(1)) とか new B("abc") の方で行くとここで例外。)
var a = JsonSerializer.Deserialize<X>(jsonA);

Console.WriteLine(a.Value);

// union X(A, B) だと A と B を弁別できないんだけども…
// (参考: UnionAmbiguousObject.cs )
union X(A, B, string); // string が来た時だけ弁別可能… 行けちゃった…
record A(int Value);
record B(string Name);
