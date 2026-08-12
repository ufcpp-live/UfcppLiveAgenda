#!
#:property AllowUnsafeBlocks=true

// Features=updated-memory-safety-rules なしでも unsafe ブロック不要に。
Console.WriteLine(nameof(A.P));

struct A
{
    // 旧ルールなので unsafe 修飾必要。これは caller-unsafe の意味ではない。
    public unsafe int* P;
}
