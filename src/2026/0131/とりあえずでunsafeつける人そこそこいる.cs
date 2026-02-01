
unsafe struct Marshal用
{
    public byte A;
    public short B;
    public int C;

    // ポインターすら含んでない。
    // 単に P/Invoke で使うというだけで unsafe 付ける人がいる。
}
