#!/usr/bin/env dotnet
#:property LangVersion preview

var x = new X(1);
x += 2;

Console.WriteLine(x.Value);

class X(int value)
{
    public int Value { get; private set; } = value;

    // こんなの。
    // クラスでも自己書き換えな演算子が書ける。
    public void operator +=(int value) => Value += value;
}
