// List capacity よりだいぶ切実な StringComparer 問題。
using System.Globalization;

HashSet<string> set = [with(comparer: StringComparer.OrdinalIgnoreCase), "a", "e", "i"];

Console.WriteLine(set.Contains("I")); // true

var turkishIgnoreCase = StringComparer.Create(new CultureInfo("tr-TR"), true);

HashSet<string> set2 = [with(turkishIgnoreCase), "a", "e", "i"];

// トルコ語だと i の大文字は İ であって I ではない。
Console.WriteLine(set2.Contains("I")); // false
