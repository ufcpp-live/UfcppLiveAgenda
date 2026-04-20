// union から生成される構造体、見るからに「readonly struct でよさそうなのに」という内容なのに… という話から、
// 「mutable な struct であることで何ができる？」話に。

U x = 0;
Console.WriteLine(x.Value); // 0

// get-only プロパティが書き変わる例。
x.M();
Console.WriteLine(x.Value); // 1

// union U(int) から生成される構造体は以下のような感じ。
#if false
struct U
{
    public object? Value { get; } // get-only なので書き換え不可。これのバッキングフィールドにも readonly が付く。

    public U(int x) => Value = x;
}
#endif

// で、「struct U」(「readonly struct U」ではない)ということは…
union U(int)
{
    public void M()
    {
        // this 自体を書き換えることで、get-only プロパティ/readonly フィールドであろうと上書き可能。
        // (readonly struct だと this 書き換えはできない。)
        this = 1;
    }
}

// ちなみに、 readonly union U(int) とか書けば、生成物も readonly struct になる。
// 「修飾子を元と生成物でそろえる」という方針。
