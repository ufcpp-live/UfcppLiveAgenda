#!
#:property LangVersion=preview

using System.Text.Json;

var json = JsonSerializer.Serialize<X>(new A(1));
//var json = JsonSerializer.Serialize<X>(new B("abc"));

Console.WriteLine(json);

// ここで例外。
// JSON value type 'Object' is ambiguous
// {} の中身まで見てない。
var x = JsonSerializer.Deserialize<X>(json);

Console.WriteLine(x.Value);

// union X(A, B) だと A と B を弁別できない。
union X(A, B);
record A(int Value);
record B(string Name);
