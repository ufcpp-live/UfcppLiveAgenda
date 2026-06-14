#:include B.cs

class A
{
    public static string Name => "A" + B.Name;
}
