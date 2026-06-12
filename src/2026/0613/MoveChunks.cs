#!

using System.Text;

var builder = new StringBuilder();

for (int i = 0; i < 5; i++)
{
    builder.Append(i);
}

// builder の内部データを完全に newBuilder に移転。
var newBuilder = StringBuilder.MoveChunks(builder);

// builder は空になっている。
Console.WriteLine(builder.ToString()); // ""

// newBuilder は builder の元の内容を保持している。
Console.WriteLine(newBuilder.ToString()); // "01234"

// まあ、Roslyn 内の内需らしい。
// SourceText.From(StringBuilder) とか AddSource(string, StringBuilder) の高速化で使ってるとか。
// ToString を経由するより当然高速。
// Source Generator のパフォーマンスを改善できる。
