List<int> x = [1, 2, 3];

// C# 15 予定
Dictionary<string, int> y = ["one": 1, "two": 2, "three": 3];
// StringComparer.OrdinalIgnoreCase とかを渡したいけど…

// 今でも行ける。
HashSet<string> z = ["apple", "banana", "cherry"];
// これこそ StringComparer.OrdinalIgnoreCase を渡したい。

// この度(来月予定)
HashSet<string> z2 = [
    with(StringComparer.OrdinalIgnoreCase),
    "apple", "banana", "cherry"];

// ↑ 概ね ↓ と一緒。
// new(arg) { 1, 2, 3 };
