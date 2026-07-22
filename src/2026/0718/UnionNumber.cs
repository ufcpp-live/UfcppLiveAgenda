using System.Text.Json;

// ダメ。
// union X(int, short) とかもダメ。
// JsonTokenType 的には全部「Number」。
// (参考: UnionIntBool.cs )
Console.WriteLine(JsonSerializer.Deserialize<X>(JsonSerializer.Serialize(1.1)).Value);

union X(int, double);
