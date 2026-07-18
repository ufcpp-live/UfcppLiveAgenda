#!
#:property LangVersion=preview

// こういう $type 弁別必須なやつのはずのものどうするんだろうって思ったら…

using System.Text.Json;

var jsonA = JsonSerializer.Serialize(new A(1));

// ここで 「JSON value type 'Object' is ambiguous for union type 'X'」とか言われる。
// それはそう。
// Serialize 側を new X(new A(1)) とかにしても、特に $type を入れてくれたりはしないっぽい。
var a = JsonSerializer.Deserialize<X>(jsonA);

Console.WriteLine(a.Value);

// JsonDerivedType 属性も付けれない(Target が class。union は struct。)
union X(A, B);
record A(int Value);
record B(string Name);
