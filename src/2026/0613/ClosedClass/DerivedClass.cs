#!
// 派生クラスも closed にしたいときは明示が必要。

#:property LangVersion=preview

// A の直接の派生だけ並べる = 網羅性チェックがかかる。
static int M1(A a) => a switch
{
    A1 => 1,
    A2 => 2,
};

// A1 の派生 + A2 = 網羅性チェックがかかる。
static int M2(A a) => a switch
{
    A11 => 11,
    A12 => 12,
    A2 => 2,
};

// A1 + A2 の派生 = かからない。(A2 の派生クラスは第三者によって増える可能性がある。)
static int M3(A a) => a switch // 警告出る。
{
    A1 => 1,
    A21 => 21,
    A22 => 22,
};

Console.WriteLine(M1(new A11()));
Console.WriteLine(M2(new A11()));
Console.WriteLine(M3(new A11()));

public closed class A;

public closed class A1 : A; // こっちは closed にする。
public class A2 : A; // こっちはしない。A2 はアセンブリの外で派生できる。

// A1 派生は網羅性チェックかかる。
class A11 : A1;
class A12 : A1;

// A2 派生はかからない。
class A21 : A2;
class A22 : A2;
