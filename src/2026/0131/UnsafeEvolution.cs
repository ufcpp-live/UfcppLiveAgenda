using System.Runtime.CompilerServices;

static ref int M(Span<int> x)
{
    // range check しているので
    if (x.Length <= 1) return ref Unsafe.NullRef<int>();

    // 呼んでる API 的には unsafe だけど、
    // 人間的には safe を保証したと言える。

    unsafe
    {
        // ref x[1] と同じものなので意味ないものの、デモ用として

        // 呼んでるものは unsafe だけど、
        // 上記 range check をもって safe。
        return ref Unsafe.Add(ref x[0], 1);

        // なので、M 自体は caller safe (unsafe 不要)
    }
}

class A
{
    // 前回配信時点: unsafe キーワードの意味を変える
    // 今回時点: [RequiresUnsafe] 属性の導入の路線が濃厚
    public static unsafe void M()
    {
    }
}

