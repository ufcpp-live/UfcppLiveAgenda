// C# 15 案(有望)
//Extra accessor in property override

abstract class X
{
    public abstract int P { get; }
}

class Y : X
{
    public override int P { get; private set; } // この set にエラー出す意味ある？
}
