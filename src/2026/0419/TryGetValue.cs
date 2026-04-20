U x = 1;
Console.WriteLine(x.Value); // 1
if (x is int i) Console.WriteLine(i); // 999。 x is int i が x.TryGetValue(out var i) になってる。

// union U(int x) だけだと TryGetValue メソッドは生成されず、
// U x; x is int は x.Value is int と同じコード生成になる。
union U(int x)
{
    // 一方で、手書きで TryGetValue を書いておくとこれが呼ばれる。
    public bool TryGetValue(out int value)
    {
        value = 999;
        return true;
    }
}
