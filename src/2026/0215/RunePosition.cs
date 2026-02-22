using System.Text;

Console.OutputEncoding = Encoding.UTF8;

const string u16 = "aαあ🐈";
ReadOnlySpan<byte> u8 = "aαあ🐈"u8;

// Rune の列挙は今までもできた。
foreach (var r in u16.EnumerateRunes())
{
    Console.WriteLine(r);
}

// 元の UTF-16 列で何文字目かが取れるように。
foreach (var r in RunePosition.EnumerateUtf16(u16))
{
    Console.WriteLine($"{r.StartIndex}-{r.Length} {r.Rune}");
}

// 同上、UTF-8 でも同じことができるように。。
foreach (var r in RunePosition.EnumerateUtf8(u8))
{
    Console.WriteLine($"{r.StartIndex}-{r.Length} {r.Rune}");
}
