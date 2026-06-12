#!
#:property LangVersion=preview

// 前まで u is A a とか u is B b はできたけど、位置パターン、プロパティパターンは使えなかったはず。

static string PositionPattern(U u) => u switch
{
    A (var name) => name,
    B (var x, var y) => $"{x}, {y}",
};

static string PropertyPattern(U u) => u switch
{
    A { Name: var name } => name,
    B { X: var x, Y: var y } => $"{x}, {y}",

    // ちなみに、↓ は「union U をパターンにはできない」エラー。
    //U { UnionProperty: var unionProperty } => unionProperty

    // ↓は UnionProperty を参照できない。A のメンバーではなく。
    //A { UnionProperty: var name } => name,
};

Console.WriteLine(PositionPattern(new U(new A("abc"))));
Console.WriteLine(PositionPattern(new U(new B(1, 2))));
Console.WriteLine(PropertyPattern(new U(new A("abc"))));
Console.WriteLine(PropertyPattern(new U(new B(1, 2))));

public record A(string Name);
public record B(int X, int Y);

union U(A, B)
{
    // ちなみに、フィールドさえ生成されなければ union にもメンバーを持てる。
    public readonly string UnionProperty => this switch
    {
        A { Name: var name } => name,
        B (var x, var y) => $"{x}, {y}",
    };
}
