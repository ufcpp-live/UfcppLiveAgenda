#!

// 「こっちの方が欲しいんだけどねぇ」(ないよ。エラー)という話。

E e1 = E.A;

_ = e1 switch
{
    E.A => "A",
    E.B => "B",
    E.C => "C",
};

// こういうこと普通にやるから exhaustive チェックが難しいというのはある。
E e = (E)(-1);

public closed enum E
{
    A,
    B,
    C
}
