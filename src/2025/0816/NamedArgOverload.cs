// これだと弁別不能。コンパイルエラー。
A.M(null);

// こっちならいける。
A.M(comperer: null);
A.M(comparison: null);

class A
{
    public static void M(IEqualityComparer<int>? comperer) { }
    public static void M(Comparison<int>? comparison) { }
}
