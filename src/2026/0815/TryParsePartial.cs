using System.Numerics;

static void M<T>(string s) where T : struct, INumber<T>
{
    Console.WriteLine((
        // 変な文字が含まれててもとりあえずその直前までは Parse してくれる。
        T.TryParsePartial(s, System.Globalization.NumberStyles.Number, null, out var result, out var chars),
        result, chars));
}

M<int>("123");  // (True, 123, 3)
M<int>("123X"); // (True, 123, 3)
M<int>("X123"); // (False, 0, 0)

// ↑みたいに露骨に変な文字列はともかく、↓みたいに「空白無視したい」用途には使えるかも。
M<int>("123\u3000\t"); // 全角スペースとタブ
