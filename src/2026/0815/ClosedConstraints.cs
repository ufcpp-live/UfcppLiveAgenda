#!
#:property LangVersion=preview

M(new A());

static int M<T>(T x)
    where T : Base
    => x switch
{
    // 「Base は closed だから T も closed 扱いで exhaustive チェックする」が今回から実装されたそうで。
    A => 1,
    B => 2,
    // _ => 不要
};

closed class Base;
class A : Base;
class B : Base;
