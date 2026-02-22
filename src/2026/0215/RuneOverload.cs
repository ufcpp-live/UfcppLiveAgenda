using System.Text;

// 🐇 を探したい。
// Rune だと '🐇' とはかけず、文字コード直書きになったりはする。
// IndexOf("🐇") で同じ結果にはなる。

var i = "🐀🐄🐅🐇🐉🐍🐎🐑🐒🐓🐕🐗".IndexOf(new Rune(0x1F407), StringComparison.Ordinal);

Console.WriteLine(i);
