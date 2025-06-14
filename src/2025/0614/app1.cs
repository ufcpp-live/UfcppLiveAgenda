#!/usr/bin/env dotnet
#:property LangVersion preview

Console.WriteLine("🐈");

record struct X(int A);

class Y
{
    public int X { set => field = value; }
}
