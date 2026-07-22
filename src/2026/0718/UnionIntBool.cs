#!
#:property LangVersion=preview

using System.Text.Json;

// OK。
// true と 1 は弁別可能。
// (「たぶん JsonTokenType だけで分岐してるだろう」という話の流れで確認。)
// (参考: UnionNumber.cs )
Console.WriteLine(JsonSerializer.Deserialize<X>(JsonSerializer.Serialize(1)).Value);
Console.WriteLine(JsonSerializer.Deserialize<X>(JsonSerializer.Serialize(true)).Value);

union X(int, bool);
