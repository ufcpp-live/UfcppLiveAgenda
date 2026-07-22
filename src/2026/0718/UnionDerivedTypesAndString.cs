#!
#:property LangVersion=preview

using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine(M(""));      // 1
Console.WriteLine(M(new A())); // 2
Console.WriteLine(M(new B())); // 3

static int M(X xc) => xc switch
{
    string => 1,
    // 一度 Base で受ける必要はなさげ。
    // close も効いてそう。
    A => 2,
    B => 3,
    // _ => がなくても警告出ない。
};

// string or A or B したければこう…
// 1段クラス/レコードを挟んで派生。
union X(string, Base);

// 元々ある JsonSerializer の仕様。
// 複数の派生クラスをシリアライズ/デシリアライズするためにはこの属性付ける。
//
// closed (union と同じく C# 15 新機能)を付けることで、Base は A と B しかないことを保証。
[JsonDerivedType(typeof(A), "A")]
[JsonDerivedType(typeof(B), "B")]
closed record Base;
record A : Base;
record B : Base;
