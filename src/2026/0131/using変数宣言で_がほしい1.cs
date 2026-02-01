using var _ = new MyScope(() => { });

// もう1個あると怒られる。
// _ が普通の変数。同名変数2個目だからエラー。
using var _ = new MyScope(() => { });

// インデント深くなる…
using (new MyScope(() => { }))
{
}

struct MyScope(Action a) : IDisposable
{
    public void Dispose()
    {
        a();
    }
}
