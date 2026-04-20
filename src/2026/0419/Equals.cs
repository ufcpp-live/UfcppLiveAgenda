// union 型の Equals はどうなっているのか確認。

// 生成される struct を覗き見るに、何も生成されてない。
// なので、構造体のデフォルトの Equals (object.Equals がオーバーライドされず元のまま) が呼ばれるはず。

// 構造体のデフォルト Equals の挙動は「フィールドごとに Equals を呼ぶ」なので、
// union の場合は Value プロパティ(のバッキングフィールド)の Equals が呼ばれるはず。

U u1 = "1";
U u2 = new string('1', 1); // Equals なのか参照の比較(ReferenceEquals) なのか確認したいので、中身同じの別インスタンスを用意。

Console.WriteLine(u1.Equals(u2)); // u1.Value.Equals(u2.Value) な挙動だった(構造体のデフォ挙動)
Console.WriteLine(u1.Value.Equals(u2.Value));
Console.WriteLine(ReferenceEquals(u1.Value, u2.Value));

// 参考: 似たような struct で確認。
S s1 = new() { Value = "1" };
S s2 = new() { Value = new string('1', 1) };

Console.WriteLine(s1.Equals(s2)); // s1.Value.Equals(s2.Value) と一致。
Console.WriteLine(s1.Value.Equals(s2.Value));
Console.WriteLine(ReferenceEquals(s1.Value, s2.Value));

union U(string x);

struct S
{
    public string Value;
}
