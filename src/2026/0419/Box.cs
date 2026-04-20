// 2重ボックス化問題。

U u = 1; // この時点でボックス化しています
object o = u; // ここでさらにボックス化しています

// これ、ユーザー定義 box 演算なくて大丈夫？…

Console.WriteLine(u is int); // true
//Console.WriteLine(u is U); // エラー(恒真)
Console.WriteLine(o is int); // false
Console.WriteLine(o is U); // true

U1 u1 = u; // これも2重ボックス
o = u1; // 3重

union U(int x);
union U1(U x);
