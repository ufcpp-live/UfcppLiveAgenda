#!
#:property LangVersion=preview

// プロパティでできてインデクサーができないというのも不自然な話で。
// 1バージョン遅れて登場。
// (実用的な利用例があるかといわれると悩む。)

using System.Numerics;

var x = 0b_1001_0101;

for (var i = 0; i < 8; i++)
{
    Console.WriteLine($"Bit {i}: {x[i]}");
}

static class Extensions
{
    extension<T>(ref T x) where T : struct, IBinaryInteger<T>
    {
        public bool this[int index]
        {
            get => (x & (T.One << index)) != T.Zero;
            set => x |= T.One << index;
        }
    }
}
