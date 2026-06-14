#!

// ref での参照 = <ProjectReference>。
// 別アセンブリ。
#:property ExperimentalFileBasedProgramEnableRefDirective=true
#:ref Lib.cs
#:property LangVersion=preview

// 以下のコードは「ライブラリ側で定義されてる closed class の参照」で、
// 合法だし、switch の網羅性チェックかかってる。
static int M(A a) => a switch
{
    A1 => 1,
    A2 => 2,
    // _ なくても警告にならない。
};

Console.WriteLine(M(new A1()));
Console.WriteLine(M(new A2()));

// ここで、A の派生クラスを作ろうとするとコンパイルエラー。
//class B : A; //エラー。

// A1 (closed class A の派生クラスだけど、こいつ自身には closed が付いてない)の派生は可能。
class B1 : A1;
