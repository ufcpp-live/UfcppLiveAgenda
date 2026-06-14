#!
// closed class = 同一アセンブリ内からしか派生できない代わりに、
// switch 式の網羅性(exhaustiveness)のチェックがかかるようになる。

#:property LangVersion=preview

static int M(A a) => a switch
{
    A1 => 1,
    A2 => 2,
    // 普通のクラスだとここに _ => とかを書かないと警告になる。
};

Console.WriteLine(M(new A1()));
Console.WriteLine(M(new A2()));

closed class A;

class A1 : A;
class A2 : A;

// ちなみに、swtich 式のコンパイル結果自体は変わらず(警告が出なくなるだけ)。
// 以下のコードとほぼ同じ。default 句相当のコードも挿入されてる。
// (unsafe な手段とかを使ってチェックをすり抜けるとちゃんと例外が出る。)
#if false
static int M(A a) => a switch
{
    A1 => 1,
    A2 => 2,
    _ => throw new SwitchExpressionException(),
};
#endif
